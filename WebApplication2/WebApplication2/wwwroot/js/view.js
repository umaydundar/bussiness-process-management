class TaskView {
    constructor() {
        this.searchField = document.getElementById('searchField');
        this.searchButton = document.getElementById('searchButton');
        this.filterField = document.getElementById('filterField');
        this.taskTable = document.getElementById('taskTable').getElementsByTagName('tbody')[0];
    }

    bindSearchHandler(handler) {
        this.searchButton.addEventListener('click', handler);
        this.searchField.addEventListener('keyup', (event) => {
            if (event.key === 'Enter') {
                handler();
            }
        });
    }

    bindFilterChangeHandler(handler) {
        this.filterField.addEventListener('change', handler);
    }

    renderTasks(tasks) {
        this.taskTable.innerHTML = '';
        tasks.forEach(task => {
            const row = this.taskTable.insertRow();
            row.insertCell(0).textContent = task.name;
            row.insertCell(1).textContent = task.description;
            row.insertCell(2).textContent = task.progress;
            row.insertCell(3).textContent = task.responsible;
            row.insertCell(4).textContent = task.creator;
            row.insertCell(5).textContent = task.created;
            row.insertCell(6).textContent = task.due;
        });
    }

    getSearchText() {
        return this.searchField.value;
    }

    getFilterValue() {
        return this.filterField.value;
    }
}
