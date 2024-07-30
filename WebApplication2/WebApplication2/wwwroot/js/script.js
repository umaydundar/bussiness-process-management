document.addEventListener('DOMContentLoaded', function () {
    const searchField = document.getElementById('searchField');
    const searchButton = document.getElementById('searchButton');
    const filterField = document.getElementById('filterField');
    const taskTable = document.querySelector('#taskTable tbody');

    const apiEndpoints = {
        tasks: 'https://localhost:5001/api/Tasks',  // Change this to your actual Tasks API endpoint
        users: 'https://localhost:5001/api/Users',
        auth: 'https://localhost:5001/api/Auth'
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
            console.log(task);
            console.log(task);
            const row = taskTable.insertRow();
            const progressPercentage = (task.refTaskStatus / task.refTaskStep) * 100;

            row.insertCell(0).textContent = task.name || 'No name provided';
            row.insertCell(1).textContent = task.description;
            row.insertCell(2).innerHTML = `<progress value="${task.refTaskStatus}" max="${task.refTaskStep}"></progress> ${progressPercentage.toFixed(2)}%`;
            row.insertCell(3).textContent = task.participants;  // Adjust based on your actual API response structure
            row.insertCell(4).textContent = task.refCustomer ;      // Placeholder for creator
            row.insertCell(4).textContent = task.refCustomer ;      // Placeholder for creator
            row.insertCell(5).textContent = task.beginDate;
            row.insertCell(6).textContent = task.endDate;

            row.addEventListener('click', () => openTaskDetails(task.id));
        });
    }

    function openTaskDetails(id) {
        window.location.href = `taskDetail.html?taskId=${id}`;  // Assuming you have a detail page setup
    function openTaskDetails(id) {
        window.location.href = `taskDetail.html?taskId=${id}`;  // Assuming you have a detail page setup
    }

    function filterTasks() {
    const searchText = searchField.value.toLowerCase();
    const filterValue = filterField.value;

    console.log('Search Text:', searchText); // Debug: Check the captured input
    console.log('Filter Value:', filterValue); // Debug: Check the filter dropdown value

    let filteredTasks = tasks;

    if (searchText) {
        filteredTasks = filteredTasks.filter(task =>
            (task.name && task.name.toLowerCase().includes(searchText)) ||
            (task.description && task.description.toLowerCase().includes(searchText))
        );
        console.log('Filtered by Search:', filteredTasks); // Debug: See filtered results after search
    }

    switch (filterValue) {
        case "completed":
            filteredTasks = filteredTasks.filter(task => task.progressPercentage === 100);
            break;
        case "active":
            filteredTasks = filteredTasks.filter(task => task.progressPercentage > 0 && task.progressPercentage < 100);
            break;
        case "pending":
            filteredTasks = filteredTasks.filter(task => task.progressPercentage === 0);
            break;
    }

    console.log('Filtered by Status:', filteredTasks); // Debug: See filtered results after status

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
