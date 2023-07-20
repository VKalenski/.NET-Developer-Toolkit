### Scaffold DiAPI .Net Project version 6.0

---

### Git

"Git is free open-source software for distributed version control: tracking changes in any set of files, usually used for coordinating workamong programmers collaboratively developing source code during software development" 
*Wikipedia 2022*

---

### GitHub

- GitHub is one of many distributed version control platforms build in Git
- Allows the distributed co-ordination of version control
- Alternative products:
    - GitLab
    - Bitbucket

---

### Ingredients

1. .NET 6 SDK (free)
2. VS Code (free): https://code.visualstudio.com/download
3. Git (free)
4. GitHub Account (free)
    - GitHub Desktop (free): https://desktop.github.com/

---

### Git Concepts

1. Repository: The Git "project" that contains versioned code*
2. Branch: Each repository has a "main" branch, but we create other branches so that we can work on new features independently
3. Clone: We can take a copy of a remote repository (from GitHub) and copy (clone) it to our local work-space
4. Fork: A copy of a repository that you can use to submit changes to the original repository with
5. Pull: Before making changes on a cloned (remote) repository it is good practice to "pull" the latest changes
6. Stage & Commit: As you make changes on your branch you will need to:
    - Select which files are to included in the change (stage)
    - Complete the change by committing them
7. Push: When working on a cloned repository we may want to push our committed changes "back-up" to the remote repository for consideration
8. Pull Request: After we have "pushed" code to the remote repository, we still need to "get approval" to merge the code into the main branch. We do this via a Pull Request
9. Code Review: The process of requiring one or more people to review the Pull Request prior to the new code being "pulled" back into Main
10. Merge: When we have complete the branch code we can merge these changes back in to the main branch

---

### Flow to work with Git and GitHub

1. Create/LogIn in https://www.github.com
2. Commands
    - ```git --version```
    - ```git config --list```
    For change primary email use:
    - ```git config --global user.email vk@gmail.com```
    - ```git config --list```
    For change primary user name use:
    - ```git config --global user.name vkalenski```
    - ```git config --list```
    Check the GitHub CLI version:
    - ```gh --version```

    Create project and use git commands to push in GitHub
    Check .NET version:
    - ```dotnet --version```
    Create console app:
    - ```dotnet new console -n PrintColour --framework new6.0```
    Go to directory:
    - ```cd Print*```
    Add .gitignore file:
    - ```dotnet new gitignore```
    Open the project with VS Code:
    - ```Code .```
    Run the console app:
    - ```dotnet run```
    Initial init file:
    - ```git init```
    Check which files is new/modified:
    - ```git status```
    Add all files:
    - ```git add .```
    Commit added files:
    - ```git commit -m "Initial Commit"```
    Check the logs:
    - ```git log```
    Check the current branch:
    - ```git branch```
    Create new branch:
    - ```git branch printGreen```
    Checkout in new branch:
    - ```git checkout printGreen```
    Build the project:
    - ```dotnet build```
    Run the project:
    - ```dotnet run```
    Return in main branch
    - ```git checkout main```
    Merge in main branch - the printGreen branch
    - ```git merge printGreen```
    Login in GitHub
    - ```gh auth login```
    Add in existing GitHub repo with no clone link:
    - ```git remote add origin https://github.com/namePerson/nameProject.git```
    Push in existing GitHub repo with no clone link:
    - ```git push origin main```
    Delete unnecessary branch:
    - ```git branch -D printGreen```

    Clone your repo:
    - ```git clone https://github.com/...```





3. 
4. 
5. 






