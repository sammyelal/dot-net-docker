## How to build the Docker Image
docker build -t name:tag .

## Create a container
docker create --name <name> <iamge>

## How to spin up the container
docker -it --rm run name arg1 arg2

## Inspect the filesystem in the container

### For Linux
docker run -it --rm --entrypoint "bash" <image> 

## Notes
Make your entrypoint.sh file executable. Git provides a way to explicitly change the permission mode of a file so that it doesn’t get reset every time there is a clone/fork.

git update-index --chmod=+x entrypoint.sh

check the permission mode
git ls-files --stage entrypoint.sh

An output like 100755 e69de29bb2d1d6434b8b29ae775ad8c2e48c5391 0       entrypoint.sh means the file has the executable permission. In this example, 755 denotes the executable permission.