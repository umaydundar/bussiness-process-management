async function createProcessList() {
    const response = await fetch('https://localhost:5001/api/Tasks');
    const tasks = await response.json();

    tasks.forEach((task) => {
        var htmlString = "";
        htmlString += `<div class="dots">`;
        for (var i = 0; i < task.refTaskStep; i++) {
            htmlString += `<span class="dot"></span>`;
        }
        htmlString += `</div>`;

        document.getElementById("search-options").innerHTML += `<div class="search-option">
                    <div class="content">
                        <div class="new-content-container">
                            <h1 class="text-lg">` + task.name + `</h1>
                            <a class="create-new text-sm-b" href= ../html/new_task_assignment.html >+Yeni Oluştur</a>
                        </div>
                        <h2 class="text-md-l"> ` + task.description + `</h2>
                        <div class="margin-between"></div>
                        <div class="level-container">
                            <h3 class="text-md-b">Aşamalar:</h3> ` + htmlString
            + `</div>
                    </div>
                </div>`;
    });
}

function showAll() {
    const groups = document.querySelectorAll(".search-option");
    groups.forEach(group => {
        group.style.display = 'block';
    });
}

async function searchTasks() {
    const searchText = document.getElementById("search").value.toLowerCase();
    const searchOptions = document.querySelectorAll(".search-option");

    searchOptions.forEach(option => {
        const taskName = option.querySelector("h1").textContent.toLowerCase();
        const taskDescription = option.querySelector("h2").textContent.toLowerCase();

        if (taskName.includes(searchText) || taskDescription.includes(searchText)) {
            option.style.display = 'block';
        } else {
            option.style.display = 'none';
        }
    });
}

document.getElementById("newTaskSearchButton").addEventListener('click', searchTasks);

document.addEventListener("DOMContentLoaded", function () {
    createProcessList().then(() => {
        var searchString = document.getElementById("search").value;
        if (searchString) {
            searchTasks();
        } else {
            showAll();
        }
    });
});
