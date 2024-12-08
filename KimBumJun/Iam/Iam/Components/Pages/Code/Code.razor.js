export function returnArrayAsync() {
    // DotNet.invokeMethodAsync('BlazorSample', 'ReturnArrayAsync')
    //     .then(data => {
    //         console.log(data);
    //     })

    console.log(`3 + 5 = ${8}`);
}

export function addHandlers() {
    const btn = document.getElementById('btn');
    btn.addEventListener('click', returnArrayAsync);
}
