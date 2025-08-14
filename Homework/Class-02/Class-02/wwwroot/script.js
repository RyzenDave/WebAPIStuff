
const getAllBtn = document.getElementById("getAllBtn");
const usersList = document.getElementById("usersList");
const indexInput = document.getElementById("indexInput");
const getByIndexBtn = document.getElementById("getByIndexBtn");
const userResult = document.getElementById("userResult");

 
const API_URL = "https://localhost:7250"; 

// === Button: Get All Users ===
getAllBtn.addEventListener("click", async () => {
    try {
        const response = await fetch(`${API_URL}/api/users`);

        if (!response.ok) {
            throw new Error(`Error: ${response.status}`);
        }

        const data = await response.json();

        // Clear old list
        usersList.innerHTML = "";
        // Fill list with usernames
        data.forEach(username => {
            const li = document.createElement("li");
            li.textContent = username;
            usersList.appendChild(li);
        });
    } catch (err) {
        usersList.innerHTML = `<li style="color:red;">Failed to load users: ${err.message}</li>`;
    }
});

// === Button: Get User by Index ===
getByIndexBtn.addEventListener("click", async () => {
    const index = indexInput.value;

    if (index === "") {
        userResult.textContent = "Please enter an index!";
        return;
    }

    try {
        const response = await fetch(`${API_URL}/api/users/${index}`);

        if (response.status === 400) {
            const errorText = await response.text();
            userResult.textContent = `Bad Request: ${errorText}`;
            userResult.style.color = "orange";
            return;
        }

        if (response.status === 404) {
            const errorText = await response.text();
            userResult.textContent = errorText;
            userResult.style.color = "red";
            return;
        }

        if (!response.ok) {
            throw new Error(`Error: ${response.status}`);
        }

        const username = await response.text(); // returns plain string
        userResult.textContent = `User at index ${index}: ${username}`;
        userResult.style.color = "green";
    } catch (err) {
        userResult.textContent = `Network error: ${err.message}`;
        userResult.style.color = "red";
    }
});