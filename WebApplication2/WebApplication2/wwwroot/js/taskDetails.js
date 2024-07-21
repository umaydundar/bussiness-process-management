// Example data loading script
document.addEventListener('DOMContentLoaded', function() {
    const queryString = window.location.search;
    const urlParams = new URLSearchParams(queryString);
    const taskId = urlParams.get('id'); // Assuming each task has a unique ID

    // Fetch task details from a server or local data structure
    fetchTaskDetails(taskId);
});

function fetchTaskDetails(taskId) {
    // Example fetching logic
    // Fetch your task details from a backend or local store
    const task = {
        id: taskId,
        name: "Example Task",
        creator: "John Doe",
        date: "2024-02-29",
        status: "Completed",
        details: "This is an example detail of the task.",
        permissions: "Read, Write"
    };

    // Populate HTML with task details
    document.getElementById('taskName').textContent = task.name;
    document.getElementById('taskCreator').textContent = task.creator;
    document.getElementById('creationDate').textContent = task.date;
    document.getElementById('taskStatus').textContent = task.status;
    document.getElementById('taskDetails').textContent = task.details;
    document.getElementById('taskPermissions').textContent = task.permissions;
}
