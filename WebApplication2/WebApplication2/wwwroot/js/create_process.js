/* create a process list from the api*/

let listGenerated = false;

async function createProcessList() {
  if (!listGenerated) {
    try {
      const response = await fetch('API Key');
      if (!response.ok) {
        throw new Error('Network response is not ok');
      }

      const rawData = await response.json();
      const processes = rawData.$values;

      if (!Array.isArray(processes)) {
        throw new Error('API response is not an array');
      }

      processes.forEach((item) => {

        const searchOptionDiv = document.createElement('div');
        searchOptionDiv.className = 'search-option';

        const contentDiv = document.createElement('div');
        contentDiv.className = 'content';

        const newContentContainerDiv = document.createElement('div');
        newContentContainerDiv.className = 'new-content-container';

        const h1Element = document.createElement('h1');
        h1Element.className = 'text-lg';
        h1Element.textContent = item.getAttribute("Name");

        const h4Element = document.createElement('h4');
        h4Element.className = 'create-new text-sm-b';
        h4Element.textContent = '+Yeni Oluştur';

        newContentContainerDiv.appendChild(h1Element);
        newContentContainerDiv.appendChild(h4Element);

        const h2Element = document.createElement('h2');
        h2Element.className = 'text-md-l';
        h2Element.textContent = item.getAttribute("Description");

        const marginBetweenDiv = document.createElement('div');
        marginBetweenDiv.className = 'margin-between';

        const levelContainerDiv = document.createElement('div');
        levelContainerDiv.className = 'level-container';

        const h3Element = document.createElement('h3');
        h3Element.className = 'text-md-b';
        h3Element.textContent = 'Aşamalar:';

        const dotsDiv = document.createElement('div');
        dotsDiv.className = 'dots';

        let dotNumber = item.getAttribute("RefTaskStep");
        for (let i = 0; i < dotNumber; i++) {
            const dotSpan = document.createElement('span');
            dotSpan.className = 'dot';
            dotsDiv.appendChild(dotSpan);
        }

        levelContainerDiv.appendChild(h3Element);
        levelContainerDiv.appendChild(dotsDiv);

        contentDiv.appendChild(newContentContainerDiv);
        contentDiv.appendChild(h2Element);
        contentDiv.appendChild(marginBetweenDiv);
        contentDiv.appendChild(levelContainerDiv);

        searchOptionDiv.appendChild(contentDiv);
        document.getElementById('search-options').appendChild(searchOptionDiv);
      });


    } catch (error) {
      console.error('Error:', error);
    }
  }
}

function showSection() {
  let name = document.getElementById("search").value;
  const groups = document.querySelectorAll('.search-option');
  groups.forEach(group => {
    if (group.getAttribute('data-type') === name) {
      group.style.display = 'block';
    } else {
      group.style.display = 'none';
    }
  });
}

function showAll(){
  const groups = document.querySelectorAll('.search-option');
  groups.forEach(group => {
    group.style.display = 'block';
  });
}

document.addEventListener("DOMContentLoaded", function() {
  const action = getParameterByName('action');
  if (action) {
    showSection(action);
  } else {
    showAll();
  }
});