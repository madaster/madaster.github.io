import fs from 'fs';
import fsa from 'node:fs/promises';
import yaml from 'js-yaml';
import matter from 'gray-matter';
import removeMd from 'remove-markdown';

// Find all countries and languages
try {
  const fileContents = fs.readFileSync('_config.yml', 'utf8');
  const data = yaml.load(fileContents);
  if (data.countries !== null) {
    for (let i = 0; i < data.countries.length; i++) {
      const languages = data.countries[i].languages.split(',');
      for (let j = 0; j < languages.length; j++) {
        createSearchFile(data.countries[i].code, languages[j]);
      }
    }
  }
} catch (e) {
  console.log(e);
}

async function createSearchFile(country, language) {
  try { 
    const pages = [];
    const allFiles = await fsa.readdir(`./${country}/${language}`);

    async function collectAllFiles(fileDirectory, directoryPath) {
      for (const file of fileDirectory) {
        const path = directoryPath + '/' + file;
        const stats = await fsa.lstat(path);
        if (stats.isDirectory() === true) {
          await collectAllFiles(await fsa.readdir(path), path);
        } else {
          pages.push(path);
        }
      }
    }

    await collectAllFiles(allFiles, `./${country}/${language}`);

    const data = await Promise.all(
      pages.map(async (page) => {
        const filePath = `${page}`;
        const file = matter.read(filePath, {
          excerpt: true,
          excerpt_separator: '',
        });
        const { data, excerpt, path, content } = file;
        const contents = removeMd(content)
        .trim()
        .split(/\r\n|\n|\r/);
        return {
        ...data,
        title: data.title,
        url: path.replace('./docs/', '').replace(/\.md$/, '.html'),
        content: contents
        .join('')
        .replace(/\s{2,}/g, '')
        .trim(),
        };
      })
    );

    await fsa.writeFile(`./assets/json/search-${country}-${language}.json`, JSON.stringify(data), 'utf-8');
  } catch (e) {
    console.log(e);
  }
}