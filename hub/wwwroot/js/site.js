async function start(id) {
    const connection = new signalR.HubConnectionBuilder().withUrl("/hub").build();
    connection.on(id, data => {
        console.log(data);
        connection.close();
    });
    await connection.start();
};