document.addEventListener('DOMContentLoaded', function () {

    document.querySelectorAll('.section-content').forEach(section => section.style.display = 'none');

    pullUserData();

    initModals();

    addInputEventListeners();
    addSaveButtonListeners();
    addCheckmarkListeners();

    setupCreateNewInputButton();
    setupInputTypeChange();
});

function toggleSection(element) {
    const sectionContent = element.closest('.section').querySelector('.section-content');
    sectionContent.style.display = sectionContent.style.display === 'none' ? 'block' : 'none';
    const arrow = element.querySelector('.arrow');
    if (arrow) {
        arrow.style.transform = sectionContent.style.display === 'none' ? 'rotate(0deg)' : 'rotate(180deg)';
    }
}

async function pullUserData() {
    const response = await fetch('https://localhost:7279/api/Users');
    const users = await response.json();

    users.forEach((user) => {
        var elms = document.querySelectorAll("#assign-users");
        for (var i = 0; i < elms.length; i++) {
            
            elms[i].innerHTML = '';
            
            elms[i].innerHTML += `<option>` + user.name + `</option>`;
        }
    });
}

function initModals() {
    const modals = document.getElementsByClassName("modal");
    const btns = document.getElementsByClassName("modal-btn");
    const spans = document.getElementsByClassName("close");

    for (let i = 0; i < btns.length; i++) {
        btns[i].onclick = function () {
            modals[i].style.display = "block";
        };
    }

    for (let i = 0; i < spans.length; i++) {
        spans[i].onclick = function () {
            modals[i].style.display = "none";
        };
    }

    window.onclick = function (event) {
        for (let i = 0; i < modals.length; i++) {
            if (event.target == modals[i]) {
                modals[i].style.display = "none";
            }
        }
    };
}

function addInputEventListeners() {
    document.querySelectorAll('input[type="text"], input[type="file"], input[type="checkbox"], select').forEach(input => {
        input.addEventListener('change', function () {
            const row = this.closest('tr');
            const dateSpan = row.querySelector('span[data-id]');
            const currentDate = new Date().toLocaleString('tr-TR', { year: 'numeric', month: '2-digit', day: '2-digit' });
            dateSpan.textContent = currentDate;

            updateStatus(row, 'started');
        });
    });
}

function addSaveButtonListeners() {
    document.querySelectorAll('.save-btn').forEach(button => {
        button.addEventListener('click', function () {
            const row = this.closest('tr');
            updateStatus(row, 'in-progress');
        });
    });
}

function addCheckmarkListeners() {
    document.querySelectorAll('.checkmark, .checkmark-continue').forEach(checkmark => {
        checkmark.addEventListener('click', function () {
            const row = this.closest('tr');
            updateStatus(row, 'completed');
        });
    });
}

function updateStatus(row, status) {
    const statusDivs = row.querySelectorAll('.not-started-div, .started-div, .in-progress-div, .completed-div');
    statusDivs.forEach(div => div.style.display = 'none');

    if (status === 'started') {
        row.querySelector('.started-div').style.display = 'block';
    } else if (status === 'in-progress') {
        row.querySelector('.in-progress-div').style.display = 'block';
    } else if (status === 'completed') {
        row.querySelector('.completed-div').style.display = 'block';
    }
}




function setupInputTypeChange() {
    const inputTypeSelect = document.getElementById('input-type-select');
    const optionsContainer = document.getElementById('options-container');
    const selectOptions = document.getElementById('select-options');

    inputTypeSelect.addEventListener('change', function () {
        if (this.value === 'select') {
            optionsContainer.style.display = 'block';
            selectOptions.style.display = 'block';
        } else {
            optionsContainer.style.display = 'none';
            selectOptions.style.display = 'none';
        }
    });
}

function setupCreateNewInputButton() {
    const createNewInputButton = document.getElementById('create-new-input');
    createNewInputButton.addEventListener('click', function () {
        const inputType = document.getElementById('input-type-select').value;
        const inputName = document.getElementById('new-input-name').value;
        const selectOptions = document.getElementById('select-options').value;

        if (!inputName) {
            alert('Lütfen yeni input için bir isim girin.');
            return;
        }

        addNewInput(inputType, inputName, selectOptions);
        closeModals();
    });
}

function addNewInput(type, name, selectOptions) {
    const firstRow = document.querySelector('table tbody tr');
    const sectionContent = firstRow.querySelector('.section-content');

    let newInput;
    if (type === 'select' && selectOptions) {
        newInput = document.createElement('select');
        newInput.setAttribute('name', name);

        const options = selectOptions.split(',').map(option => option.trim());
        options.forEach(optionText => {
            const option = document.createElement('option');
            option.textContent = optionText;
            newInput.appendChild(option);
        });
    } else {
        switch (type) {
            case 'text':
                newInput = document.createElement('textarea');
                newInput.setAttribute('name', name);
                newInput.setAttribute('placeholder', name);
                break;
            case 'checkbox':
                newInput = document.createElement('input');
                newInput.setAttribute('type', 'checkbox');
                newInput.setAttribute('name', name);
                const label = document.createElement('label');
                label.textContent = name;
                sectionContent.appendChild(newInput);
                sectionContent.appendChild(label);
                return; 
            case 'file':
                newInput = document.createElement('input');
                newInput.setAttribute('type', 'file');
                newInput.setAttribute('name', name);
                break;
            default:
                console.error('Geçersiz input türü');
                return;
        }
    }

    sectionContent.appendChild(newInput);
}

function closeModals() {
    const modals = document.getElementsByClassName("modal");
    for (let i = 0; i < modals.length; i++) {
        modals[i].style.display = "none";
    }
}

function initModals() {
    const modals = document.getElementsByClassName("modal");
    const btns = document.getElementsByClassName("modal-btn");
    const spans = document.getElementsByClassName("close");

    for (let i = 0; i < btns.length; i++) {
        btns[i].onclick = function () {
            modals[i].style.display = "block";
        };
    }

    for (let i = 0; i < spans.length; i++) {
        spans[i].onclick = function () {
            modals[i].style.display = "none";
        };
    }

    window.onclick = function (event) {
        for (let i = 0; i < modals.length; i++) {
            if (event.target == modals[i]) {
                modals[i].style.display = "none";
            }
        }
    };
}
