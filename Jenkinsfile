pipeline {
    agent any

    tools {
        dotnetsdk "dotnet-8.0" // or 7.0, based on your Jenkins config
    }

    environment {
        APP_DIR = "SampleDotNetApp"
        DEPLOY_SERVER = "ec2-user@50.17.16.43" 
        PEM_PATH = "/Users/hemant7122/InternshipAssignments/SampleDotNetApp/LLB.pem"
    }

    stages {
        stage('Clone Repo') {
            steps {
                git branch: 'main', url: 'https://github.com/IamY0uu/Dnet.git'
            }
        }

        stage('Restore Dependencies') {
            steps {
                sh 'dotnet restore'
            }
        }

        stage('Build App') {
            steps {
                sh 'dotnet build --configuration Release'
            }
        }

        stage('Publish App') {
            steps {
                sh 'dotnet publish -c Release -o publish_output'
            }
        }

        stage('Deploy App (Local)') {
            steps {
                // Stop existing process (if any) and restart
                sh '''
                pkill -f "dotnet" || true
                nohup dotnet publish_output/SampleDotNetApp.dll > app.log 2>&1 &
                '''
            }
        }
    }
}
