const toggleSections = document.getElementsByClassName("toggle-section");
const completeButtons = document.getElementsByClassName("btn");
const modals = document.getElementsByClassName("modal");
const btns = document.getElementsByClassName("modal-btn");
const spans = document.getElementsByClassName("close");


function toggleSection(element) {
    const sectionContent = element.nextElementSibling;
    sectionContent.style.display = sectionContent.style.display === 'none' ? 'block' : 'none';
    const index = Array.from(toggleSections).indexOf(element);
    if (toggleSections[index].getAttribute("status") === "completed") {
        assignStatus("completed", element);
    }
    else {
        assignStatus("in-progress", element);
    }
}

document.querySelectorAll('.section-content').forEach(section => section.style.display = 'none');

async function pullUserData() {
    const response = await fetch('https://localhost:5001/api/Users');
    const users = await response.json();

    users.forEach((user) => {

        var elms = document.querySelectorAll("[id='assign-users']");

        for (var i = 0; i < elms.length; i++) {
            elms[i].innerHTML += `<option>` + user.name + `</option>`;
        }
    });
}
document.addEventListener("DOMContentLoaded", function () {
    pullUserData();
    assignStatus("none");
});

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
        if (event.target === modals[i]) {
            modals[i].style.display = "none";
        }
    }
};

for (let i = 0; i < completeButtons.length; i++) {
    completeButtons[i].onclick = function () {
        if (toggleSections[i].getAttribute("status") !== "completed") {
            document.getElementsByClassName("not-started-div")[i].style.display = "none";
            document.getElementsByClassName("in-progress-div")[i].style.display = "none";
            document.getElementsByClassName("completed-div")[i].style.display = "block";
            toggleSections[i].setAttribute("status", "completed");
            createNewInput();
        }
    };
}

document.querySelector(".assignment-completed-btn").addEventListener("click", function () {
    postData();
    window.location.href = `../html/main.html`;
});

async function createNewInput() {
    let allCompleted = true;
    for (const element of toggleSections) {
        if (element.getAttribute("status") !== "completed") {
            allCompleted = false;
            break;
        }
    }
    const assignmentCompletedModal = document.querySelector(".assignment-completed-modal");
    if (allCompleted) {
        assignmentCompletedModal.style.display = "block";
    } else {
        assignmentCompletedModal.style.display = "none";
    }
}

function assignStatus(status, element) {
    if (status === "in-progress" && element) {
        const index = Array.from(toggleSections).indexOf(element);
        document.getElementsByClassName("not-started-div")[index].style.display = "none";
        document.getElementsByClassName("in-progress-div")[index].style.display = "block";
        document.getElementsByClassName("completed-div")[index].style.display = "none";
        toggleSections[index].setAttribute("status", "in-progress");
    }
    else if (status === "completed" && element) {
        const index = Array.from(toggleSections).indexOf(element);
        document.getElementsByClassName("not-started-div")[index].style.display = "none";
        document.getElementsByClassName("in-progress-div")[index].style.display = "none";
        document.getElementsByClassName("completed-div")[index].style.display = "block";
        toggleSections[index].setAttribute("status", "completed");
        createNewInput();
    }
    else {
        for (let i = 0; i < toggleSections.length; i++) {
            if (status === "none") {
                document.getElementsByClassName("not-started-div")[i].style.display = "block";
                document.getElementsByClassName("in-progress-div")[i].style.display = "none";
                document.getElementsByClassName("completed-div")[i].style.display = "none";
                toggleSections[i].setAttribute("status", "not-started");
            }
        }
    }
}


function postData() {
    const currentdate = new Date();
    const task = {
      /*  Id: 5,
        RecordTime: currentdate.toISOString(),
        RefCustomer: 1,
        ServiceNo: "-",
        RefTemplateTask: 3,
        Name: "task1",
        BeginDate: currentdate.toISOString(),
        EndDate: currentdate.toISOString(),
        RefTaskStep: 3,
        RefTaskStatus: 0,
        RefDepartment: 2,
        Description: "-",
        Participants: "-",*/
    };

    fetch(`https://localhost:5001/api/Tasks`, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(task)
    })
        .then(response => {
            if (!response.ok) {
                throw new Error(`HTTP error! status: ${response.status}`);
            }
            return response.json();
        })
        .then(data => {
            console.log('Success:', data);
            window.location.reload();
        })
        .catch((error) => {
            console.error('Error:', error);
        });
}


// Handling creation of new inputs based on selection type
const inputBtns = document.getElementsByClassName("modal-create-new-input-btn");

for (let i = 0; i < inputBtns.length; i++) {
    inputBtns[i].onclick = function () {
        const inputNames = document.getElementsByClassName("input-name");
        const selectType = document.getElementsByClassName("select-input");
        const inputDivs = document.getElementsByClassName("input-div");

        let newInput = "";

        if (selectType[i].value === "Text Area") {
            newInput = `<input type="text" class="input-area-si text-sm"/>`;
        } else if (selectType[i].value === "Selection Box") {
            newInput = ` <select class="select-input"></select>
                         <button>Add Selection option</button>`;
        } else if (selectType[i].value === "Checkbox") {
            newInput = `<input type="checkbox" unchecked>`;
        } else if (selectType[i].value === "File Upload") {
            newInput = `<input type="file" id="upload" name="upload">`;
        }
        else { }
        inputDivs[i].innerHTML += `<label class="text-sm-l">${inputNames[i].value}</label>${newInput}`;

        newInput = "";
    };
}
