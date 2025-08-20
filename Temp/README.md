# Temp

```bash
dotnet build -v:d > build.log

dotnet build -v:normal
dotnet build -v:detailed
dotnet build -v:diag
```

```xml
$(SolutionDir): 솔루션 파일(.sln)이 있는 디렉토리의 전체 경로.
$(SolutionName): 솔루션 파일의 이름.
$(ProjectDir): 현재 프로젝트 파일(.csproj)이 있는 디렉토리의 전체 경로.
$(ProjectName): 현재 프로젝트의 이름.
$(ProjectPath): 현재 프로젝트 파일의 전체 경로 (이름 포함).
$(OutDir): 최종 빌드 결과물이 저장될 디렉토리 경로 (예: bin/Debug/net9.0/).
$(Configuration): 현재 빌드 구성 (예: Debug 또는 Release).
$(Platform): 현재 빌드 플랫폼 (예: AnyCPU).
$(TargetFramework): 프로젝트의 대상 프레임워크 (예: net9.0).
$(OS): 현재 빌드를 실행하는 운영체제 (macOS에서는 Unix, Windows에서는 Windows_NT).
```
