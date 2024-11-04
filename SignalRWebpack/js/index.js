"use strict";
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    var desc = Object.getOwnPropertyDescriptor(m, k);
    if (!desc || ("get" in desc ? !m.__esModule : desc.writable || desc.configurable)) {
      desc = { enumerable: true, get: function() { return m[k]; } };
    }
    Object.defineProperty(o, k2, desc);
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
Object.defineProperty(exports, "__esModule", { value: true });
const signalR = __importStar(require("@microsoft/signalr"));
require("./index.css");
const divMesssages = document.querySelector("#divMessages");
const tbMessage = document.querySelector("#tbMessage");
const btnSend = document.querySelector("#btnSend");
const username = new Date().getTime();
const connection = new signalR.HubConnectionBuilder()
    .withUrl("/hub")
    .build();
connection.on("messgeReceived", (username, message) => {
    const m = document.createElement("div");
    m.innerHTML = `<div class="message-author">${username}</div><div>${message}</div>`;
    if (divMesssages)
        divMesssages.appendChild(m);
    if (divMesssages)
        divMesssages.scrollTop = divMesssages.scrollHeight || 0;
});
connection.start().catch(err => document.write(err));
if (tbMessage)
    tbMessage.addEventListener("keyup", (e) => {
        if (e.key === "Enter") {
            send();
        }
    });
btnSend === null || btnSend === void 0 ? void 0 : btnSend.addEventListener("click", send);
function send() {
    if (tbMessage === null || tbMessage === void 0 ? void 0 : tbMessage.value)
        connection.send("newMessage", username, tbMessage === null || tbMessage === void 0 ? void 0 : tbMessage.value)
            .then(() => tbMessage.value = "");
}