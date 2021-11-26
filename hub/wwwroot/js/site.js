const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chathub")
    .configureLogging(signalR.LogLevel.Information)
    .build();

async function start() {
    try {
        connection.on("1", data => {
            console.log(data);
        });
        await connection.start();
    } catch (err) {
        setTimeout(start, 5000);
    }
};

connection.onclose(async () => {
    await start();
});

start();
document.getElementById("btn").onclick = (event) => {
    connection.invoke("message", { id: "1", message: "demo" });
}