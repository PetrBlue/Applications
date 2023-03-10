#!/bin/bash

# Change directory to the local folder
cd C:\\Users\\admin\\Desktop\\CSharp

# Copy the contents of the local folder to the clone of the remote repository
cp -r ./* C:\\Users\\admin\\Desktop\\CSharp\\Applications

# Change directory to the clone of the remote repository
cd C:\\Users\\admin\\Desktop\\CSharp\\Applications

# Stage all changes in the working tree
git add .

# Commit the changes with the commit message "Auto commit."
git commit -m "Auto commit."

# Push the changes to the remote repository on the `main` branch
git push origin main