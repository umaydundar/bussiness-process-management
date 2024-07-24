﻿document.addEventListener('DOMContentLoaded', function () {
    const searchField = document.getElementById('searchField');
    const searchButton = document.getElementById('searchButton');
    const filterField = document.getElementById('filterField');
    const taskTable = document.querySelector('#taskTable tbody');

    const apiEndpoints = {
        tasks: 'https://localhost:5001/api/tasks',  // Change this to your actual Tasks API endpoint
        users: 'https://localhost:5001/api/users',
        auth: 'https://localhost:5001/api/auth'
    };

    let tasks = [];

    async function fetchTasks() {
        try {
            const response = await fetch(apiEndpoints.tasks);
            tasks = await response.json();
            tasks = tasks.map(task => ({
                ...task,
                progressPercentage: calculateProgress(task.refTaskStatus, task.refTaskStep)
            }));

            console.log(tasks);  // Log the tasks to see what is received
            renderTasks(tasks);
        } catch (error) {
            console.error('Error fetching tasks:', error);
        }
    }
    function calculateProgress(status, step) {
        return (status / step) * 100;
    }

    function renderTasks(filteredTasks) {
        taskTable.innerHTML = '';
        filteredTasks.forEach(task => {
            const row = taskTable.insertRow();
            const progressPercentage = (task.refTaskStatus / task.refTaskStep) * 100;

            row.insertCell(0).textContent = task.name || 'No name provided';
            row.insertCell(1).textContent = task.description;
            row.insertCell(2).innerHTML = `<progress value="${task.refTaskStatus}" max="${task.refTaskStep}"></progress> ${progressPercentage.toFixed(2)}%`;
            row.insertCell(3).textContent = task.participants;  // Adjust based on your actual API response structure
            row.insertCell(4).textContent = task.refCustomer;      // Placeholder for creator
            row.insertCell(5).textContent = task.beginDate;
            row.insertCell(6).textContent = task.endDate;

            row.addEventListener('click', () => openTaskDetails(task.id));
        });
    }

    function openTaskDetails(taskId) {
        window.location.href = `task-details.html?taskId=${taskId}`;  // Assuming you have a detail page setup
    }

    function filterTasks() {
        const searchText = searchField.value.toLowerCase();
        const filterValue = filterField.value;

        let filteredTasks = tasks;

        if (searchText) {
            filteredTasks = filteredTasks.filter(task =>
                task.name.toLowerCase().includes(searchText) ||
                task.description.toLowerCase().includes(searchText)
            );
        }

        if (filterValue === "completed") {
            filteredTasks = filteredTasks.filter(task => task.progressPercentage === 100);
        } else if (filterValue === "active") {
            filteredTasks = filteredTasks.filter(task => task.progressPercentage > 0 && task.progressPercentage < 100);
        } else if (filterValue === "pending") {
            filteredTasks = filteredTasks.filter(task => task.progressPercentage === 0);
        }

        renderTasks(filteredTasks);
    }


    searchButton.addEventListener('click', filterTasks);
    filterField.addEventListener('change', filterTasks);
    searchField.addEventListener('keyup', function (event) {
        if (event.key === 'Enter') {
            filterTasks();
        }
    });

    fetchTasks();
});
