all: build
BEPINEX_VERSION = 6

clean:
	@dotnet clean

restore:
	@dotnet restore

build: clean restore
	@dotnet build /p:BepInExVersion=$(BEPINEX_VERSION)

package-win:
	@-mkdir dist
	@cmd /c copy /y "bin\Debug\netstandard2.1\0Harmony.dll" "dist\"
	@cmd /c copy /y "bin\Debug\netstandard2.1\MyCoolMod.dll" "dist\"
	@echo Packaged to dist/

package-unix: build
	@-mkdir dist
	@cp bin/Debug/netstandard2.1/0Harmony.dll dist
	@cp bin/Debug/netstandard2.1/MyCoolMod.dll dist
	@echo Packaged to dist/