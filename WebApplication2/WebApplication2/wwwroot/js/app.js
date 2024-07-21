document.addEventListener('DOMContentLoaded', function() {
    const model = new TaskModel();
    const view = new TaskView();
    new TaskController(model, view);
});
