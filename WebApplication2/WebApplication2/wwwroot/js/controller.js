class TaskController {
    constructor(model, view) {
        this.model = model;
        this.view = view;
        
        this.view.bindSearchHandler(this.handleSearch.bind(this));
        this.view.bindFilterChangeHandler(this.handleFilterChange.bind(this));

        // Initial fetch and render
        this.model.fetchTasks().then(() => {
            this.view.renderTasks(this.model.tasks);
        });
    }

    handleSearch() {
        const searchText = this.view.getSearchText();
        const filterValue = this.view.getFilterValue();
        const filteredTasks = this.model.getFilteredTasks(searchText, filterValue);
        this.view.renderTasks(filteredTasks);
    }

    handleFilterChange() {
        this.handleSearch(); // Reuse search handling to apply filters
    }
}
