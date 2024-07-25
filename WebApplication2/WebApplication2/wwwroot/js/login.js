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

/*document.addEventListener("DOMContentLoaded", function () {
    document.getElementById('options-container').style.display = 'none';
    document.getElementByClassName("btn - login").addEventListener("click", showForm("login"));
    document.getElementByClassName("btn-signup").addEventListener("click", showForm("signup"));
});*/


/*document.addEventListener('DOMContentLoaded', function () {

    const signupForm = document.getElementById('signup-form');
    signupForm.addEventListener('submit', function (event) {
        event.preventDefault();  

        // Gather the data from the form
        const email = document.getElementById('signup-username-email').value;
        const password = document.getElementById('signup-password').value;

        // Create the data object to send
        const signupData = {
            email: email,
            password: password
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
                document.getElementById('message').textContent = 'Signup successful: ' + data.message;
                document.getElementById('login-form').style.display = 'block';
                document.getElementById('signup-form').style.display = 'none';
            })
            .catch(error => {
                document.getElementById('message').textContent = 'Signup failed.';
                console.error('Error:', error);
            });
    });

    const loginForm = document.getElementById('login-form');
    loginForm.addEventListener('submit', function (event) {
        event.preventDefault();  // Prevent the default form submission

        // Gather the data from the form
        const email = document.getElementById('login-username-email').value;
        const password = document.getElementById('login-password').value;
      
        // Create the data object to send
        const loginData = {
            email: email,
            password: password
        };

        // Send the data to the server using fetch API
        fetch('https://localhost:5001/api/Users/Login', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(loginData)
        })
            .then(response => {
                if (response.ok) {
                    return response.json();
                } else {
                    throw new Error('Failed to login');
                }
            })
            .then(data => {
                document.getElementById('message').textContent = 'Login successful: ' + data.message;
            })
            .catch(error => {
                document.getElementById('message').textContent = 'Login failed. Please check your email and password.';
                console.error('Error:', error);
            });
    });
});
*/