# Cities: Skylines 2 - C# Mod template

This repository template allows you to get started with Cities: Skylines 2 modding easily.

# Requirements

- [Cities: Skylines 2](https://store.steampowered.com/app/949230/Cities_Skylines_II/) (duh)
- [BepInEx-Unity.Mono-win-x64-6.0.0-be.674+82077ec](https://builds.bepinex.dev/projects/bepinex_be)
- (Optional) [dotnet-script](https://github.com/dotnet-script/dotnet-script) (for `rename.csx` and `version-dump.csx` helper scripts)
    - Installation `dotnet tool install -g dotnet-script`

# Usage

- Create a new repository based on this one
- Clone your new repository to your computer
- Uncomment and update the `Cities2_Location` variable in `MyCoolMod.csproj`
- Run `make build`

After running the last command, the mod should be automatically copied to your game directory,
so launching the game should include running the mod you just started :)

# Regarding BepInEx version 5 (Stable) VS 6 (Alpha/Unstable/Nightly)

Currently, this mod template defaults to building against BepInEx version 6 (unstable pre-release). If you'd like to instead use Stable BepInEx version 5, you can run the build like this:

```
$ make build BEPINEX_VERSION=5
```

In order to run code only for one BepInEx version, you can do something like this:

```
#if BEPINEX_V6
    using BepInEx.Unity.Mono;
#endif
```

That would only run `using BepInEx.Unity.Mono` when you're building the project for BepInEx 6. Add in a `else` if you want to do something different when it's version 5.

# CI / GitHub Actions - Setup

In order to get the CI/GitHub Actions workflow to work, you have to do a couple of things.

- Create a new private repository with all the game DLLs that you require for building your mod
- Create a new GitHub Personal Access Token ("PAT") that has only READ access to the created private repository
- Create a new secret variable in GitHub Actions called `GH_PAT` that has your PAT with read access to the private repository

Now the CI job should work as expected :)

# Community

Looking to discuss Cities: Skylines 2 Unofficial modding together with other modders? You're welcome to join our "Cities 2 Modding" Discord, which you can find here: https://discord.gg/vd7HXnpPJf