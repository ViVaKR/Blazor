# Kim Bum Jun

```bash
npm install tailwindcss postcss autoprefixer postcss-cli
npm tailwindcss init

dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools

# -m : 모델이름
# -dc : 네임스페이스를 포함하여 사용할 DbContext 클래스
# -udl : 기본 레이아웃
# -outDir : 뷰를 만들기 위한 상태 출력 폴더 경로
# --referenceScriptLibraries : Edit 및 Create 페이지에 _ValidtionScriptsPartial 을 추가함.
dotnet aspnet-codegenerator razorpage -m Movie -dc Iam.Data.IamContext -udl -outDir Components/Pages/Movie --databaseProvider sqlite
```

## **postcss.config.js**

```json
module.exports = {
  plugins: {
    tailwindcss: {},
    autoprefixer: {},
  },
}
```

```bash
npx tailwindcss -i ./Iam/wwwroot/css/styles.css -o ./Iam/wwwroot/css/styles.min.css --watch

history
npm install @tailwindcss/forms
npm install @tailwindcss/typography
npm install @tailwindcss/aspect-ratio
npm install @tailwindcss/line-clamp
```

## .razor

- @using
- @section
- @typeparam
- @attributes
- @bind
- @bind:culture
- @formname
- @on{EVENT}
- @on{EVENT}:stopPropagation
- @key
- @ref

### HTML

**Attributes**

- a : anchor
    - href : 연결하고자 하는 웹 주소, href="<https://code.vivabm.com>"
    - title : 링크에 대한 추가 정보, title="The Viv Homepage"
    - target : 링크가 어떻게 열릴 것인지 를 지정
    - disabled

**tag**
> a
  abbr
  address
  area
  article
  aside
  audio
  b
  base
  bdi
  bdo
  blockquote
  body
  br
  button
  canvas
  caption
  code
  col
  colgroup
  data
  datalist
  dd
  del
  details
  dialog
  div
  dl
  em
  embed
  fieldset
  figcaption
  figure
  footer
  form
  h1, h2, h3, h4, h5, h6
  head
  header
  hgroup
  hr
  html
  i
  iframe
  img
  input
  ins
  kbd
  label
  legend
  li
  link
  main
  map
  mark
  MathML
  menu
  meta
  meter
  nav
  noscript
  object
  ol
  optgroup
  option
  output
  p
  picture
  pre
  pregress
  q
  rp
  rt
  ruby
  s
  samp
  script
  section
  select
  slot
  small
  source
  span
  strong
  style
  sup
  svg
  table
  template
  textarea
  tfoot
  th
  thead
  time
  title
  tr
  track
  u
  ul
  var
  video
  wbr
