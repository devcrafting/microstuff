# microstuff
BuildStuff ASP.NET 5 Microservices tutorial application

## Install from scratch on a LUbuntu VM

Here is a step by step guide to create a LUbuntu VM to run the ASP.NET 5 app in docker

* Create a VM with your favorite hypervisor and install LUbuntu 15.10 (could try with other versions, but it works with these one for me)
* Once installed and started, install Mono http://www.mono-project.com/docs/getting-started/install/linux/
```bash
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb http://download.mono-project.com/repo/debian wheezy main" | sudo tee /etc/apt/sources.list.d/mono-xamarin.list
sudo apt-get update
sudo apt-get install mono-complete
```
* Then, install ASP.NET 5 from : https://docs.asp.net/en/latest/getting-started/installing-on-linux.html#installing-on-debian-ubuntu-and-derivatives, main steps are :
  * Install curl `sudo apt-get install curl`
  * Download and install DNVM (Dot Net Version Manager) `curl -sSL https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.sh | DNX_BRANCH=dev sh && source ~/.dnx/dnvm/dnvm.sh` 
  * Install DNX for Mono (I did not manage to make it work with .NET Core) `dnvm upgrade -r mono` (everything has been installed for Mono)
* Install Docker : https://docs.docker.com/engine/installation/ubuntulinux/, main steps are :
```bash
sudo apt-key adv --keyserver hkp://p80.pool.sks-keyservers.net:80 --recv-keys 58118E89F3A912897C070ADBF76221572C52609D
echo "deb https://apt.dockerproject.org/repo ubuntu-wily main" > sudo tee -a /etc/apt/sources.list.d/docker.list
sudo apt-get update
sudo apt-get install linux-image-extra-$(uname -r)
sudo apt-get install docker-engine
sudo service docker start
```
To test if docker works: `sudo docker run hello-world`
* Install Docker Compose (I take 1.5.1) : https://docs.docker.com/compose/install/
```bash
curl -L https://github.com/docker/compose/releases/download/1.5.1/docker-compose-`uname -s`-`uname -m` | sudo tee -a /usr/local/bin/docker-compose
sudo chmod +x /usr/local/bin/docker-compose
```
* Install NodeJS 5: https://nodejs.org/en/download/package-manager/#debian-and-ubuntu-based-linux-distributions
```bash
curl -sL https://deb.nodesource.com/setup_5.x | sudo -E bash -
sudo apt-get install -y nodejs
```
* Install VSCode: https://code.visualstudio.com/ (download, unzip and run ./code inside unzip path)

You are done for installation, then you have to clone this repository and just build & run application through docker.