# Password Generator

This is a little and lightweight password generator made in C#.
The .NET Framework is required.

---
## How do I start it?

### Windows

You need to install the .NET Framework. \
Then simply click on `password-generator.exe`.

---

### Linux

#### Debian based systems
```bash
$ sudo apt update && sudo apt upgrade
$ sudo install mono-complete
```
To then execute the app:
```bash
$ mono "Password Generator.exe"
```

#### Fedora systems
```bash
$ sudo dnf update
$ sudo dnf install mono-develop
```
To then execute the app:
```bash
$ mono "Password Generator.exe"
```

#### Arch based systems
```bash
$ sudo pacman -Syu
$ sudo pacman -S mono
```
To then execute the app:
```bash
$ mono "Password Generator.exe"
```

#### openSUSE Factory systems
```bash
$ sudo zypper addrepo https://download.opensuse.org/repositories/openSUSE:Factory/standard/openSUSE:Factory.repo
$ sudo zypper refresh
$ sudo zypper install mono-complete
```
To then execute the app:
```
$ mono "Password Generator.exe"
```

### MacOS

```bash
$ sudo port install mono
$ mono "Password Generator.exe"
```
