document.addEventListener("DOMContentLoaded", function () {
    const id = new URLSearchParams(window.location.search).get('taskId');
    fetchTaskDetails(id);
    fetchHiringDetails(id);
});

function fetchTaskDetails(id) {
    fetch(`https://localhost:5001/api/Tasks/${id}`)
        .then(response => response.json())
        .then(data => {
            document.getElementById('taskName').textContent = data.name;
            document.getElementById('description').textContent = data.description;
        })
        
  
        .catch(error => console.error('Error fetching task details:', error));
}

function fetchHiringDetails(taskId) {
    fetch(`https://localhost:5001/api/HiringDetails/ByTask/${taskId}`)
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json();
        })
        .then(data => {
            if (data && data.length > 0) {
                updateDOM(data[0]);
            } else {
                console.error('No data available');

            }
        })
        .catch(error => {
            console.error('Error fetching hiring details:', error);
            //document.getElementById('ResponsibleUserName').textContent = 'Error loading data';

        });
}

function updateDOM(details) {
    let nameDisplay = document.getElementById('HireName');
    let nameInput = document.getElementById('nameInput');
    let deptDisplay = document.getElementById('Department');
    let deptInput = document.getElementById('deptInput');
    let saveButton = document.getElementById('saveButton');
    let permissionsSelect = document.getElementById('permissionsSelect');
    let saveButton2 = document.getElementById('saveButton2');
    let checkboxes = [document.getElementById('checkbox1'), document.getElementById('checkbox2'), document.getElementById('checkbox3')];
    let saveButton3 = document.getElementById('saveButton3');
    //let statusText = document.getElementById('Status3');

    //document.getElementById('HireName').textContent = details.hireName || 'No Name Provided';
    //document.getElementById('Department').textContent = details.department || 'No Department Provided';
    document.getElementById('ResponsibleUserName').textContent = details.responsibleUserName || 'No Responsible User';
    document.getElementById('CompletionDate').textContent = details.completionDate || 'No Responsible User';
    document.getElementById('CompletionDate2').textContent = details.completionDate2 || 'No Responsible User';
    document.getElementById('CompletionDate3').textContent = details.completionDate3 || 'No Responsible User';
    document.getElementById('UserName2').textContent = details.userName2 || 'No Responsible User';
    document.getElementById('UserName3').textContent = details.userName3 || 'No Responsible User';
   // document.getElementById('CompletionDate').textContent = details.completionDate || 'No Responsible User';

    console.log(document.getElementById('ResponsibleUserName').textContent);
    console.log(document.getElementById('UserName2').textContent);
    console.log(document.getElementById('UserName3').textContent);


    console.log(document.getElementById('HireName').textContent);
    console.log(document.getElementById('CompletionDate').textContent);

    document.getElementById('Status').textContent = details.status || 'No Responsible User';
    document.getElementById('Status2').textContent = details.status2 || 'No Responsible User';
    document.getElementById('Status3').textContent = details.status3 || 'No Responsible User';

    if (details.status === 'completed') {
        nameDisplay.innerText = details.hireName;
        deptDisplay.innerText = details.department;
        nameDisplay.style.display = 'block';
        deptDisplay.style.display = 'block';
        nameInput.style.display = 'none';
        deptInput.style.display = 'none';
        saveButton.style.display = 'none';
    } else {
        nameInput.value = details.hireName;
        deptInput.value = details.department;
        nameDisplay.style.display = 'none';
        deptDisplay.style.display = 'none';
        nameInput.style.display = 'block';
        deptInput.style.display = 'block';
        saveButton.style.display = 'block';
    }
    //document.getElementById('CompletionDate').textContent = details.completionDate || 'No Date Provided';
    if (permissionsSelect && saveButton2) {
        if (details.status2 === 'completed') {
            permissionsSelect.value = 'Erişim'; // assuming 'Erişim' is the permission set when completed
            permissionsSelect.disabled = true; // disable the dropdown
            saveButton2.style.display = 'none'; // hide the save button
        } else {
            
            permissionsSelect.style.display = 'block';
            permissionsSelect.disabled = false;
            saveButton2.style.display = 'block';
        }
    } else {
        console.error('DOM elements are missing.');
    }
    if (details.status3 === 'completed') {
        checkboxes.forEach(checkbox => {
            checkbox.checked = true;
            checkbox.disabled = true;
        });
        saveButton3.style.display = 'none';
        //statusText.innerText = 'Completed';
    } else {
        checkboxes.forEach(checkbox => {
            checkbox.disabled = false;
        });
        saveButton3.style.display = 'block';
        //statusText.innerText = details.Status3;
    }
    
}
function saveChanges() {
    const taskId = new URLSearchParams(window.location.search).get('taskId');
    const hireName = document.getElementById('nameInput').value;
    const department = document.getElementById('deptInput').value;

    const hiringDetails = {
       // DetailID: taskId, // This should match the backend expected ID field
        HireName: hireName,
        Department: department,
        Status: 'completed',
        
    };

    fetch(`https://localhost:5001/api/HiringDetails/ByTask/${taskId}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(hiringDetails)
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Failed to update hiring details');
            }
            return response.json();
        })
        .then(data => {
            console.log('Success:', data);
            // Optionally, refresh or redirect after successful update
            window.location.reload(); // This will refresh the page to reflect changes
        })
        .catch((error) => {
            console.error('Error:', error);
        });
}

function saveStatus2() {
    const taskId = new URLSearchParams(window.location.search).get('taskId');
    const selectedPermission = document.getElementById('permissionsSelect').value;

    let newStatus = 'pending'; // Default status
    if (selectedPermission === 'Erişim') {
        newStatus = 'completed'; // Set to completed or any other status based on logic
    }

    const hiringDetailsUpdate = {
        Status2: newStatus  // Update status based on selection
    };
    const dataToSend = {
        //TaskId: taskId,
        Status2: newStatus
    };
    fetch(`https://localhost:5001/api/HiringDetails/UpdateStatus/${taskId}`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(dataToSend)
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Failed to update status');
            }
            return response.json();
        })
        .then(data => {
            console.log('Status updated:', data);
            window.location.reload(); // Optionally refresh the page to reflect changes
        })
        .catch((error) => {
            console.error('Error updating status:', error);
        });
}
function saveStatus3() {
    const taskId = new URLSearchParams(window.location.search).get('taskId');
    //const selectedPermission = document.getElementById('permissionsSelect').value;

    
    const dataToSend = {
        //TaskId: taskId,
        Status3: 'completed',
    };
    fetch(`https://localhost:5001/api/HiringDetails/UpdateStatus3/${taskId}`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(dataToSend)
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Failed to update status');
            }
            return response.json();
        })
        .then(data => {
            console.log('Status updated:', data);
            window.location.reload(); // Optionally refresh the page to reflect changes
        })
        .catch((error) => {
            console.error('Error updating status:', error);
        });
}
