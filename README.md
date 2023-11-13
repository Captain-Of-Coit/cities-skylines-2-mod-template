# Cities: Skylines 2 - C# Mod template

This repository template allows you to get started with Cities: Skylines 2 modding easily.

# Requirements

- [Cities: Skylines 2](https://store.steampowered.com/app/949230/Cities_Skylines_II/) (duh)
- [BepInEx-Unity.Mono-win-x64-6.0.0-be.674+82077ec](https://builds.bepinex.dev/projects/bepinex_be)

# Usage

- Create a new repository based on this one
- Clone your new repository to your computer
- Uncomment and update the `Cities2_Location` variable in `MyCoolMod.csproj`
- Run `make build`

After running the last command, the mod should be automatically copied to your game directory,
so launching the game should include running the mod you just started :)

# CI / GitHub Actions - Setup

In order to get the CI/GitHub Actions workflow to work, you have to do a couple of things.

- Create a new private repository with all the game DLLs that you require for building your mod
- Create a new GitHub Personal Access Token ("PAT") that has only READ access to the created private repository
- Create a new secret variable in GitHub Actions called `GH_PAT` that has your PAT with read access to the private repository

Now the CI job should work as expected :)

# Community

Looking to discuss Cities: Skylines 2 Unofficial modding together with other modders? You're welcome to join our "Cities 2 Modding" Discord, which you can find here: https://discord.gg/vd7HXnpPJf