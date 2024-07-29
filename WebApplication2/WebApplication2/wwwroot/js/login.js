function showForm(formType) {
    document.getElementById('options-container').style.display = 'none';
    if (formType === 'login') {
        document.getElementById('login-form').style.display = 'block';
        document.getElementById('signup-form').style.display = 'none';
    } else {
        document.getElementById('login-form').style.display = 'none';
        document.getElementById('signup-form').style.display = 'block';
    }
}


document.addEventListener('DOMContentLoaded', function () {

    const signupForm = document.getElementById('signup-form');
    signupForm.addEventListener('submit', function (event) {
        event.preventDefault();  

        // Gather the data from the form
        const email = document.getElementById('signup-username-email').value;
        const password = document.getElementById('signup-password').value;

        // Create the data object to send
        const signupData = {
            Name: "-",
            Email: email,
            Phone: "-",
            Password: password,
        };

        // Send the data to the server using fetch API
        fetch('https://localhost:5001/api/Users', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(signupData)
        })
            .then(response => {
                if (response.ok) {
                    return response.json();
                } else {
                    throw new Error('Failed to signup');
                }
            })
            .then(data => {
                document.getElementById('login-form').style.display = 'block';
                document.getElementById('signup-form').style.display = 'none';
            })
            .catch(error => {
                console.error('Error:', error);
            });
    });

    const loginForm = document.getElementById('login-form');
    loginForm.addEventListener('submit', function (event) {
        event.preventDefault();  

        const email = document.getElementById('login-username-email').value;
        const password = document.getElementById('login-password').value;

        loginFormSubmit(email, password);
       
    });
});

async function loginFormSubmit(email, password) {
    const response = await fetch('https://localhost:5001/api/Users');
    const users = await response.json();

    let userLogFound = false;
    users.forEach((user) => {
        if (user.email == email && user.password == UserController.CreatePasswordHash(password));
       {
           console.log("Login succesful");
           userLogFound = true;
           window.location.href = "../html/main.html"
       }
    });

    if(!userLogFound) 
    {
        console.log("Login failed");
    }
}