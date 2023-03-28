# Prepare-Calculator
## Creating a new develop branch

To create a new develop branch from the master branch, use the following command:

```bash
git checkout -b develop
```
## Checking the status of your working directory

To check the status of your working directory, use the following command:

```bash
git status
```

## Adding changes to the staging area

To add changes to the staging area, use the following command:

```bash
git add .
```

## Committing changes to the local repository

To commit changes to the local repository, use the following command:

```bash
git commit -m "Your commit message"
```

## Pushing changes to the remote repository

To push changes to the remote repository, use the following command:

```bash
git push origin develop
```

## Merging feature branch into develop

To merge a feature branch into develop, use the following commands:

```bash
git checkout develop # switch to develop branch
git pull origin develop # update develop branch from remote
git merge feature # merge feature branch into develop
git push origin develop # push changes to remote
```