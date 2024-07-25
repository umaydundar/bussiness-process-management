function toggleSection(element) {
    const sectionContent = element.nextElementSibling;
    
    sectionContent.style.display = sectionContent.style.display === 'none' ? 'block' : 'none';
    sectionContent.icon.toggle('arrow');
}

document.querySelectorAll('.section-content').forEach(section => section.style.display = 'none');

async function pullUserData(){
    const response = await fetch('https://localhost:5001/api/Users');
    const users = await response.json();

    users.forEach((user) => {

        var elms = document.querySelectorAll("[id='assign-users']");

        for (var i = 0; i < elms.length; i++)
        {
            elms[i].innerHTML += `<option>` + user.name + `</option>`;
        }
    });
}

document.addEventListener("DOMContentLoaded", function () {
    pullUserData();
   /* document.getElementsByClassName("not-started-div").style.diplay("none");
    document.getElementsByClassName("in-progress-div").style.diplay("none");
    document.getElementsByClassName("completed-div").style.diplay("none");
    assignStatus("none");*/
});


modals = document.getElementsByClassName("modal");
var btns = document.getElementsByClassName("modal-btn");
var spans = document.getElementsByClassName("close");

for (var i = 0; i < btns.length; i++) {
    (function (i) {
        btns[i].onclick = function () {
            modals[i].style.display = "block";
        };
    })(i);
}

for (var i = 0; i < spans.length; i++) {
    (function (i) {
        spans[i].onclick = function () {
            modals[i].style.display = "none";
        };
    })(i);
}

window.onclick = function (event) {
    for (var i = 0; i < modals.length; i++) {
        if (event.target == modals[i]) {
            modals[i].style.display = "none";
        }
    }
};


//todo if the togle section is not toggled show not started div
//else if toggle section is opened but not a person assigned by and saved show in progress div
//if a person assigned and saved show completed div
//if every task step is completed then open modal box and send user to main page 

/*let displayed = false;

async function assignStatus(status) {
    const toggleSections = document.getElementsByClassName("toggle-section");
    for (let i = 0; i < toggleSections.length; i++) {
        let sectionContent = toggleSections[i].nextElementSibling;
        if (status == "none" && sectionContent && sectionContent.style.display === "none" && !displayed) {
            document.getElementsByClassName("not-started-div")[0].style.display = "block";
            document.getElementsByClassName("in-progress-div")[0].style.display = "none";
            document.getElementsByClassName("completed-div")[0].style.display = "none";
            displayed = true;
        } else if (status == "completed") {
            document.getElementsByClassName("not-started-div")[0].style.display = "none";
            document.getElementsByClassName("in-progress-div")[0].style.display = "none";
            document.getElementsByClassName("completed-div")[0].style.display = "block";
        }
        else
        {
            document.getElementsByClassName("not-started-div")[0].style.display = "none";
            document.getElementsByClassName("in-progress-div")[0].style.display = "block";
            document.getElementsByClassName("completed-div")[0].style.display = "none";
        }
    }
}


document.querySelectorAll('.btn').forEach(btn => {
    btn.addEventListener('click', () => {
        assignStatus("completed");
    });
});
*/