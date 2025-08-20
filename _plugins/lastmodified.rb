# frozen_string_literal: true

# require "jekyll"
# require "lastmodified/version"
# require "lastmodified/hook"

module LastModified
  autoload :Determinator, "lastmodified/determinator"
  autoload :Git, "lastmodified/git"
  autoload :Executor, "lastmodified/executor"

  PATH_CACHE = {}
  REPO_CACHE = {}
end
