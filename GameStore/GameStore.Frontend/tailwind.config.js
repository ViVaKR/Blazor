/** @type {import('tailwindcss').Config} */
const config = {
  content: [
    "./Components/**/*.{razor,html}",
    "./wwwroot/index.html"
  ],
  theme: {

    extend: {
      container: {
        center: true,

        padding: {
          DEFAULT: '1rem',
          sm: '2rem',
          md: '4rem',
          lg: '6rem',
          xl: '8rem',
          '2xl': '12rem',
        }
      },
      columns: {
        '4xs': '14rem',
      },
      screens: {
        'tablet': '640px',// => @media (min-width: 640px) {...}
        'laptop': '1024px',// => @media (min-width: 1024px) {...}
        'desktop': '1280px',// => @media (min-width: 1280px) {...}

      },
      spacing: {
        sm: '8px',
        md: '12px',
        lg: '16px',
        xl: '24px',
        '128': '32rem',

      },
      flexBasis: {
        '1/7': '14.2857143%',
        '2/7': '28.5714286%',
        '3/7': '42.8571429%',
        '4/7': '57.1428571%',
        '5/7': '71.4285714%',
        '6/7': '85.7142857%',
      },
      "colors": {
        primary: 'rgba(var(--color-primary), 1)',
        secondary: 'rgba(var(--color-secondary), 1)',
        space: '#5c6ac6',
        transparent: 'transparent',
        current: 'currentColor',
        black: '#000',
        white: '#fff',
        midnight: '#121063',
        metal: '#565584',
        'tahiti': {
          100: '#cffafe',
          200: '#a5f3fc',
          300: '#67e8f9',
          400: '#22d3ee',
          500: '#06b6d4',
          600: '#0891b2',
          700: '#0e7490',
          800: '#155e75',
          900: '#164e63',
          light: '#67e8f9',
          DEFAULT: '#06b6d4',
          dark: '#0e7490',
        },
        brown: {
          50: '#fdf8f6',
          100: '#f2e8e5',
          200: '#eaddd7',
          300: '#e0cec7',
          400: '#d2bab0',
          500: '#bfa094',
          600: '#a18072',
          700: '#977669',
          800: '#846358',
          900: '#43302b',
        },
        silver: '#ecebff',
        snow: '#f9f9f9',
        'bubble-gum': '#ff77e9',
        'light-pink': '#ffbbca',
        'bermuda': '#78dcca',
        /*
        lime: '#a3e634',
        green: '#4ade80',
        emerald: '#34d399',
        teal: '#2dd4bf',
        cyan: '#22d3ee',
        sky: '#38bdf8',
        blue: '60a5fa',
        indigo: '#818cf8',
        violet: '#a78bfa',
        purple: '#c084fc',
        fuchsia: '#e879f9',
        pink: '#f472b6',
        rose: '#fb7185',
        */
      },
      "fontFamily": {
        display: 'Oswald, ui-serif',
        'ko-diphy': 'Diphylleia, serif',
        poppins: 'Poppins, sans-serif',
        cute: 'Cute Font, cursive',
        lato: 'Lato, sans-serif',
        dongle: 'Dongle, sans-serif',
        'fira-code': 'Fira Code, monospace',
        roboto: 'Roboto, sans-serif',
        lato: 'Lato, sans-serif',
      },
      "letterSpacing": {
        "tightest": "-0.075em",
        tighter: '-0.05em',
        tight: '-0.025em',
        normal: '0',
        wide: '0.025em',
        wider: '0.05em',
        widest: '0.25em',
      },
      lineClamp: {
        7: '7',
        8: '8',
        9: '9',
        10: '10',
      },
      gridTemplateColumns: {
        '8': 'repeat(8, minmax(0, 1fr))',
        '16': 'repeat(16, minmax(0, 1fr))',
        'footer': '10% minmax(40%, 1fr) 10%',
      },
      gridColumnStart: {
        '13': '13',
        '14': '14',
        '15': '15',
        '16': '16',
        '17': '17',
      },
      gridColumnEnd: {
        '13': '13',
        '14': '14',
        '15': '15',
        '16': '16',
        '17': '17',
      },
      opacity: {
        '0': '0',
        '10': '0.1',
        '20': '0.2',
        '30': '0.3',
        '40': '0.4',
        '50': '0.5',
        '60': '0.6',
        '70': '0.7',
        '80': '0.8',
        '90': '0.9',
        '100': '1',
      },
      transitionDuration: {
        '0': '0ms',
        '2000': '2s',
        '3000': '3s',
        '4000': '4s',
        '5000': '5s',
        '6000': '6s',
        '7000': '7s',
        '8000': '8s',
        '9000': '9s',
        '10000': '10s',
      },
      transitionTimingFunction: {
        'in-expo': 'cubic-bezier(0.95, 0.05, 0.795, 0.035)',
        'out-expo': 'cubic-bezier(0.19, 1, 0.22, 1)'
      },
      transitionDelay: {
        '2000': '2s',
        '3000': '3s',
      },
      animation: {
        'spin-slow': 'spin 3s linear infinite',
      },
      scale: {
        '175': '1.75',
        '200': '2',
        '300': '3',
        '400': '4',
      },
      textUnderlineOffset: {
        3: '3px',
      },
      textIndent: {
        '128': '32rem',
      },
      lineHeight: {
        'extra-loose': '2.5',
        '12': '3rem',
        '14': '3.5rem',
        '16': '4rem',
        '18': '4.5rem',
        '20': '5rem'
      },
      listStyleImage: {
        checkmark: 'url("/images/checkmark.svg")',
      },
      listStyleType: {
        square: 'square',
        roman: 'upper-roman',
        circle: 'circle',

      }
    },
  },
  plugins: [
    require('@tailwindcss/forms'),
  ],
};

export default config;
