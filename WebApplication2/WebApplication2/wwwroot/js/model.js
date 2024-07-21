class TaskModel {
    constructor() {
        this.tasks = [];
    }

    fetchTasks() {
        // Placeholder for server fetching logic
        return fetch('https://api.yourdomain.com/tasks')
            .then(response => response.json())
            .then(tasks => {
                this.tasks = tasks;
                return tasks;
            });
    }

    getFilteredTasks(searchText, filterStatus) {
        return this.tasks.filter(task => {
            const matchesSearchText = searchText ?
                task.name.toLowerCase().includes(searchText.toLowerCase()) ||
                task.description.toLowerCase().includes(searchText.toLowerCase()) : true;
            const matchesStatus = filterStatus ? task.status === filterStatus : true;
            return matchesSearchText && matchesStatus;
        });
    }
}
