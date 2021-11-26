document.getElementById("btn").onclick = (event) => {
    fetch("/api/task").then(rs => rs.text()).then(rs => start(rs))
}