# madaster.github.io
Documentation of the Madaster Platform

## Run locally
  Install: https://jekyllrb.com/docs/installation/windows/
  bundle install
  bundle exec jekyll serve

## Run locally in WSL
sudo apt-get install -y ruby-full build-essential zlib1g-dev

echo '# Install Ruby Gems to ~/gems' >> ~/.bashrc
echo 'export GEM_HOME="$HOME/gems"' >> ~/.bashrc
echo 'export PATH="$HOME/gems/bin:$PATH"' >> ~/.bashrc
source ~/.bashrc

gem install jekyll bundler
# restore gems
bundle install

# run site
bundle exec jekyll serve
