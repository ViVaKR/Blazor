export default {
    content: [
        './VivGames/**/*.razor',
        './VivGames.Client/**/*.razor',
        '!./VivGames/**/obj/**/*',
        '!./VivGames.Client/**/obj/**/*',
        '!./node_modules/**/*'
    ],
    theme: {extend: {}},
    plugins: [],
    important: true,
};
