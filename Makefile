
test:
	dotnet test
run:
	dotnet run --project src/App/App.fsproj
flush:
	find . -iname "bin" -o -iname "obj" | xargs rm -rf
	