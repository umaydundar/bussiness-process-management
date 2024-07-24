function toggleSection(element) {
    const sectionContent = element.nextElementSibling;
    
    sectionContent.style.display = sectionContent.style.display === 'none' ? 'block' : 'none';
    sectionContent.icon.classList.toggle('arrow');
}

// Initialize all sections to be closed
document.querySelectorAll('.section-content').forEach(section => section.style.display = 'none');

//todo make the selection part dynamic pull out the user data for selection options 
//todo fix create new input part
//todo write js code for accept and completed parts 

async function pullUserData(){
    const response = await fetch('https://localhost:5001/api/Users');
    const users = await response.json();

    users.forEach((user) => {
        document.getElementById("assign-users").innerHTML +=  `<option value="Erişim">`+ user.Name + `</option>`;
    });
}

document.addEventListener("DOMContentLoaded", function () {
    pullUserData();
});
