import * as signalR from '@microsoft/signalr';
import "./css/index.css";
const divMesssages: HTMLDivElement | null = document.querySelector("#divMessages");
const tbMessage: HTMLInputElement | null = document.querySelector("#tbMessage");
const btnSend: HTMLButtonElement | null = document.querySelector("#btnSend");
const username = new Date().getTime();

const connection = new signalR.HubConnectionBuilder()
    .withUrl("/hub")
    .build();

connection.on("messgeReceived", (username: string, message: string) => {
    console.log('messageReceived', username, message);
    const m = document.createElement("div");
    m.innerHTML = `<div class="message-author">${username}</div><div>${message}</div>`;
    if (divMesssages)
        divMesssages.appendChild(m);

    if (divMesssages)
        divMesssages.scrollTop = divMesssages.scrollHeight || 0;
});

connection.start().catch(err => document.write(err));
if (tbMessage)
    tbMessage.addEventListener("keyup", (e: KeyboardEvent) => {
        if (e.key === "Enter") {
            send();
        }
    });

btnSend?.addEventListener("click", send);

function send() {
    if (tbMessage?.value)
        connection.send("newMessage", username, tbMessage?.value)
            .then(() => tbMessage.value = "");
}
