var action_limitation = 8;
var userSession = JSON.parse(sessionStorage.getItem("user"));
if(!userSession){
    window.location.href = "login.html";
}

function logOut() {
    sessionStorage.removeItem("user");
    window.location.href = "login.html";
}

async function AddAction(){
    var response = await fetch(`http://localhost:51911/api/Login/${userSession.ID}`, {
        method: "PUT",
        headers: {"Content-Type": "application/json"},
        body: JSON.stringify()   
    });
    var data = await response.json();
    sessionStorage.setItem("user", JSON.stringify(data));
    
    if(+userSession.number_of_action > action_limitation){
        alert("Yor are out of moves!")
        window.location.href = "login.html";
    }
}

