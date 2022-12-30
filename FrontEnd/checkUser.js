var actions_limit= 8;
try {
    var userSession = JSON.parse(sessionStorage.getItem("user"));
} catch (error) {
    window.location.href = "login.html";
}

if(+userSession.number_of_action > actions_limit){
    alert("Go Out!")
    window.location.href = "login.html";
}