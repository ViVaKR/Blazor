Blazor 웹앱 (C#)
작성자 :Microsoft
설명: 서버 측 렌더링 및 클라이언트 대화형 작업을 모두 지원하는 Blazor 웹앱을 만들기 위한 프로젝트 템플릿입니다. 이 템플릿은 풍부한 동적 UI(사용자 인터페이스)가 있는 웹앱에 사용할 수 있습니다.
이 템플릿에는 Microsoft 이외의 타사 기술이 포함되어 있습니다. 자세한 내용은https://aka.ms/aspnetcore/8.0-third-party-notices을(를) 참조하세요.

사용법:
  dotnet new blazor [options] [템플릿 옵션]

옵션:
  -n, --name <name>       생성 중인 출력의 이름입니다. 이름을 지정하지 않으면 출력 디렉터리의 이름이 사용됩니다.
  -o, --output <output>   생성된 출력을 배치할 위치입니다.
  --dry-run               템플릿이 생성될 경우 주어진 명령 줄이 실행되면 어떤 일이 발생하는지에 대한 요약을 표시합니다.
  --force                 기존 파일을 변경하더라도 콘텐츠를 강제로 생성합니다.
  --no-update-check       템플릿을 인스턴스화할 때 템플릿 패키지 업데이트 확인을 사용하지 않도록 설정합니다.
  --project <project>     컨텍스트 평가에 사용해야 하는 프로젝트입니다.
  -lang, --language <C#>  인스턴스화할 템플릿 언어를 지정합니다.
  --type <project>        인스턴스화할 템플릿 형식을 지정합니다.

템플릿 옵션:
  -f, --framework <net8.0>    프로젝트에 대한 대상 프레임워크입니다.
                              유형: choice
                                net8.0  대상 net8.0
                              기본값: net8.0
  --no-restore                지정된 경우, 프로젝트 생성 시 자동 복원을 건너뜁니다.
                              유형: bool
                              기본값: false
  --exclude-launch-settings   생성된 템플릿에서 launchSettings.json을 제외할지 여부입니다.
                              유형: bool
                              기본값: false
  -int, --interactivity <선택>  대화형 구성 요소에 사용할 호스팅 플랫폼을 선택합니다.
                              유형: choice
                                None         대화형 작업 없음(정적 서버 렌더링만 해당)
                                Server       서버에서 실행
                                WebAssembly  WebAssembly를 사용하여 브라우저에서 실행
                                Auto         WebAssembly 자산을 다운로드하는 동안 서버를 사용한 
                              다음, WebAssembly를 사용합니다.
                              기본값: Server
  -e, --empty                 기본 사용 패턴을 보여주는 샘플 페이지 및 스타일을 생략할지 여부를 구성합니다.
                              유형: bool
                              기본값: false
  -au, --auth <선택>            사용할 인증 유형
                              유형: choice
                                None        인증 없음
                                Individual  개별 인증
                              기본값: None
  -uld, --use-local-db        SQLite 대신 LocalDB를 사용할지 여부입니다. 이 옵션은 --auth 
                              Individual이 지정된 경우에만 적용됩니다.
                              유형: bool
                              기본값: false
  -ai, --all-interactive      최상위 수준에서 대화형 렌더링 모드를 적용하여 모든 페이지를 대화형으로 설정할지 여부를 
                              구성합니다. 만약 false이면 페이지는 기본적으로 정적 서버 렌더링을 사용하며 페이지별 
                              또는 구성 요소별로 대화형으로 표시될 수 있습니다.
                              다음 경우에 사용: (InteractivityPlatform != "None")
                              유형: bool
                              기본값: false
  --no-https                  HTTPS를 끌지 여부입니다. 이 옵션은 개별 항목이 --auth에 사용되지 않는 
                              경우에만 적용됩니다.
                              유형: bool
                              기본값: false
  --use-program-main          최상위 문 대신 명시적 Program 클래스 및 Main 메서드를 생성할지 여부입니다.
                              유형: bool
                              기본값: false

