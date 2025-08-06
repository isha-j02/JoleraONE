document.getElementById("logout")?.addEventListener("click", function(e) {
  e.preventDefault();
  localStorage.clear();
  window.location.href = "login.html";
});
