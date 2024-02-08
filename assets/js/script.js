const modals = document.querySelectorAll('[data-modal]');
const h2Elements = Array.from(document.getElementsByTagName("h2")).filter(el => el.hasAttribute('id'));
// const h3Elements = Array.from(document.getElementsByTagName("h3")).filter(el => el.hasAttribute('id'));

modals.forEach(function (trigger) {
  trigger.addEventListener('click', function (event) {
    event.preventDefault();
    const modal = document.getElementById(trigger.dataset.modal);
    modal.classList.add('open');
    const exits = modal.querySelectorAll('.modal-exit');
    exits.forEach(function (exit) {
      exit.addEventListener('click', function (event) {
        event.preventDefault();
        modal.classList.remove('open');
      });
    });
  });
});

function addActiveClass() {
  const urlMap = window.location.pathname.split('/')[3];
  if (urlMap) {
    const activeNav = document.getElementById(`menu-item-${urlMap}`);
    if (activeNav) {
      activeNav.classList.add('active');
    }
  }
}

function toggleMenu() {
  const elements = document.getElementsByClassName("toggle-menu");
  const menu = document.getElementsByClassName("mobile-menu")[0];
  
  Array.prototype.forEach.call(elements, function(el) {
    if (el.classList.contains('active')) {
      el.classList.remove('active');
    } else {
      el.classList.add('active');
    }
  });

  if (menu.classList.contains('active')) {
    menu.classList.remove('active');
  } else {
    menu.classList.add('active');
  }
};

function addLinkChainElements(array) {
  for (let i = 0; i < array.length; i++) {
    const title = array[i].innerHTML;
    array[i].innerHTML = "";
    // Add class
    array[i].classList.add("linkable-title");
    // Generate 'a' element
    const newAnchor = document.createElement("a");
    newAnchor.classList.add("link-chain");
    newAnchor.href = window.location.href + '#' + array[i].id;
    // Generate img element
    const newImg = document.createElement("img");
    newImg.src = "/assets/images/link-chain.svg";
    newAnchor.appendChild(newImg);
    // Add 'a' element to heading
    array[i].appendChild(newAnchor);
    // Generate span element
    const newSpan = document.createElement("span");
    newSpan.innerHTML = title;
    // Add 'span' element
    array[i].appendChild(newSpan);
  }
}

function addSubmenuIDLinks() {
  const headings = Array.from(document.getElementsByClassName('content')[0].getElementsByTagName('h2'));
  if (headings.length > 0) {
    const pageTitle = document.getElementsByTagName('h1')[0].innerText;
    const menuListItems = Array.from(document.getElementsByClassName('menu-list')[0].getElementsByTagName('li'));
    const currentMenuListItem = menuListItems.find(m => m.innerText === pageTitle);
    const newUnorderedList = document.createElement("ul");
    newUnorderedList.classList.add("generated-anchor-menu");
    // Add unordered list
    currentMenuListItem.appendChild(newUnorderedList);
    // Add list items
    for (let i = 0; i < headings.length; i++) {
      let newMenuListItem = document.createElement("li");
      let newMenuListItemAnchor = document.createElement("a");
      newMenuListItemAnchor.href = '#' + headings[i].id;
      newMenuListItemAnchor.innerText = headings[i].innerText;
      newMenuListItem.appendChild(newMenuListItemAnchor);
      newUnorderedList.appendChild(newMenuListItem);
    }
  }
}

addActiveClass();
addLinkChainElements(h2Elements);
// addLinkChainElements(h3Elements);
function addResourceMenu(){
  const currentMenuListItem = document.getElementById('release-notes');
  const headings = Array.from(document.getElementsByClassName('content')[0].querySelectorAll('h2, h3'));

  if (headings.length > 0 && currentMenuListItem) { 
    let hasChild = false;
    let newMenuListItem = document.createElement("li");
    let newUnorderedList = document.createElement("ul");
    for (let i = 0; i < headings.length; i++) {
        
        if (headings[i].tagName=='H2')
        {  
          newMenuListItem = document.createElement("li");
          hasChild=false;
          let newMenuListItemAnchor = document.createElement("a");
          newMenuListItemAnchor.href = '#' + headings[i].id;
          newMenuListItemAnchor.innerText = headings[i].innerText;
          newMenuListItem.appendChild(newMenuListItemAnchor); 
          currentMenuListItem.parentElement.appendChild(newMenuListItem);
        }
        else
        {
          if (!hasChild){
            newUnorderedList = document.createElement("ul");
            newUnorderedList.classList.add("generated-anchor-menu");
            newMenuListItem.appendChild(newUnorderedList);
          }
          
          let newChildMenuListItem = document.createElement("li");
          let newChildMenuListItemAnchor = document.createElement("a");
          newChildMenuListItemAnchor.href = '#' + headings[i].id;
          newChildMenuListItemAnchor.innerText = headings[i].innerText;
          newChildMenuListItem.appendChild(newChildMenuListItemAnchor); 
          newUnorderedList.appendChild(newChildMenuListItem);
          hasChild=true;
        }
    
    }

    currentMenuListItem.remove();
  }
}



if (window.location.pathname.split('/')[3] === 'get-started' || window.location.pathname.split('/')[3] === 'knowledge-base'  || window.location.pathname.split('/')[3] === 'resources') {
  if (window.location.pathname.split('/')[3] === 'resources') {
    addResourceMenu();
 }
  else{
    addSubmenuIDLinks();
    
  }

  const navLinks = document.querySelectorAll('.generated-anchor-menu li a');
  window.addEventListener('scroll', function() {
    const fromTop = window.scrollY;
  
    navLinks.forEach(function(link, index) {
      const section = document.querySelector(link.hash);
      const nextSection = navLinks[index + 1] ? document.querySelector(navLinks[index + 1].hash) : null;
  
      if (
        (section.offsetTop <= fromTop && (!nextSection || nextSection.offsetTop > fromTop)) ||
        (index === navLinks.length - 1 && fromTop > section.offsetTop)
      ) {
        link.classList.add('is-active-anchor');
      } else {
        link.classList.remove('is-active-anchor');
      }
    });
  });
}
