async function getSearchResults(country, language) {
  return fetch(`/assets/json/search-${country}-${language}.json`)
  .then((response)=>response.json())
  .then((responseJson)=>{return responseJson});
}

// Go to search page from home
function goToSearchHome(event) {
  event.preventDefault();
  const inputValue = document.getElementById("search-input-home").value;
  location.href = window.location.origin + window.location.pathname.substring(0,7) + "search?query=" + inputValue;
}

// Go to search page from nav
function goToSearchNavDesktop(event) {
  event.preventDefault();
  const inputValue = document.getElementById("search-input-nav-desktop").value;
  location.href = window.location.origin + window.location.pathname.substring(0,7) + "search?query=" + inputValue;
}

// Go to search page from nav
function goToSearchNavMobile(event) {
  event.preventDefault();
  const inputValue = document.getElementById("search-input-nav-mobile").value;
  location.href = window.location.origin + window.location.pathname.substring(0,7) + "search?query=" + inputValue;
}

async function initiateSearch(country, language) {
  const searchResults = await getSearchResults(country, language);
  let idx = lunr(function () {
    this.field('title');
    this.field('content');
    this.ref('url');

    for(let i = 0; i < searchResults.length; i++) {
      this.add(searchResults[i]);
    }
  });
  
  // get the input and button elements
  const input = document.getElementById('search-input');
  const searchButton = document.getElementById('search-button');

  // listen for the searchButton click
  searchButton.addEventListener('click', function (event) {
    event.preventDefault();

    if(input.value.length > 1) {

    // get the search results
    results = idx.search(input.value);

    // remove the previous search results
    const resultContainer = document.getElementById('search-results-list');
    resultContainer.innerHTML = '';

    // create elements to display the search results
    resultsFull = results.map(function (item) {
      return searchResults.filter(function (value) {
        return value.url === item.ref;
      })[0];
    }).filter(r => r.exclude !== true);

    const resultAmountContainer = document.getElementById('search-results-summary');
    const resultAmountContainerOne = document.getElementById('search-results-summary-one');

    if (resultsFull.length === 1) {
      resultAmountContainer.classList.remove("active");
      resultAmountContainerOne.classList.add("active");
      document.getElementById('search-result-one').innerHTML = resultsFull.length;
      document.getElementById('search-term-one').innerHTML = input.value;
    } else {
      resultAmountContainer.classList.add("active");
      resultAmountContainerOne.classList.remove("active");
      document.getElementById('search-result').innerHTML = resultsFull.length;
      document.getElementById('search-term').innerHTML = input.value;
    }

    for (let i = 0; i < resultsFull.length; i++) {
      let doc = resultsFull[i];
      let title = document.createElement('h4');
      title.innerHTML = doc.title;
      let url = document.createElement('a');
      url.href = doc.url.substring(1, doc.url.length);
      url.appendChild(title);
      let content = document.createElement('p');
      if (doc.description) {
        content.innerHTML = doc.description;
      } else {
        content.innerHTML = doc.content.substring(0, 80);
      }
      let tags = document.createElement('div');
      if (doc.type) {
        let tagType = document.createElement('span');
        tagType.classList.add("tag-type");
        tagType.innerHTML = doc.type;
        tags.appendChild(tagType);
      }
      let result = document.createElement('li');
      result.appendChild(url);
      result.appendChild(content);
      result.appendChild(tags);
      resultContainer.appendChild(result);
    }
  }});
  const queryString = window.location.search;
  if(queryString) {
    document.getElementById('search-input').value = (queryString.split("?query=")[1]).replaceAll('%20',' ');
    const event = new Event('click');
    searchButton.dispatchEvent(event);
  }
};

const fullUrl = window.location.href;
const urlPath = window.location.pathname.split('/');

if(fullUrl.startsWith(window.location.origin + '/' + urlPath[1] + '/' + urlPath[2] + '/search')) {
  initiateSearch(urlPath[1], urlPath[2]);
}
