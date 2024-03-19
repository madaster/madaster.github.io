---
title: Search
ref: search
menubar: none
exclude: true
---

<section class="search">
  <div class="search-wrapper">
    <h2>Zoeken in Madaster Docs</h2>
    <form class="search-form content-container flex-column-center">
      <input type="text" class="search-bar" id="search-input" autocomplete="off" aria-label="Zoek invoer">
      <button type="submit" class="search-button-icon" id="search-button" aria-label="Zoek knop">
        <svg width="24" height="24" viewBox="0 0 20 20">
          <path d="M9.5,3A6.5,6.5 0 0,1 16,9.5C16,11.11 15.41,12.59 14.44,13.73L14.71,14H15.5L20.5,19L19,20.5L14,15.5V14.71L13.73,14.44C12.59,15.41 11.11,16 9.5,16A6.5,6.5 0 0,1 3,9.5A6.5,6.5 0 0,1 9.5,3M9.5,5C7,5 5,7 5,9.5C5,12 7,14 9.5,14C12,14 14,12 14,9.5C14,7 12,5 9.5,5Z" fill="#398684" fill-rule="evenodd"/>
        </svg>
      </button>
    </form>
  </div>
</section>

<div id="search-results">
  <div id="search-results-wrapper">
    <div id="search-results-summary">
      <p>Weergave van <span id="search-result"></span> resultaten voor "<span id="search-term"></span>"</p>
    </div>
    <div id="search-results-summary-one">
      <p>Weergave van <span id="search-result-one"></span> resultaten voor "<span id="search-term-one"></span>"</p>
    </div>
    <ul id="search-results-list">
    </ul>
  </div>
</div>