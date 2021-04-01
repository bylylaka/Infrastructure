pipeline{
    agent any
        
    stages{
        stage('Checkout') {
                steps {
                    git 'https://github.com/bylylaka/Infrastructure'
            }
        }
        
        stage('Restore packages'){
            steps{
                bat "dotnet restore Infrastructure\\Infrastructure.csproj"
            }
        }
        
        stage('Clean'){
            steps{
                bat "dotnet clean Infrastructure\\Infrastructure.csproj"
            }
       }
       
       stage('Build'){
           steps{
              bat "dotnet build Infrastructure\\Infrastructure.csproj --configuration Release"
            }
        }
        
        stage('Publish'){
            steps{
                bat "dotnet publish Infrastructure\\Infrastructure.csproj"
            }
        }
    }
    
    post{
        always{
            emailext body: "${currentBuild.currentResult}: Job   ${env.JOB_NAME} build ${env.BUILD_NUMBER}\n More info at: ${env.BUILD_URL}",
            recipientProviders: [[$class: 'DevelopersRecipientProvider'], [$class: 'RequesterRecipientProvider']],
            subject: "Jenkins Build ${currentBuild.currentResult}: Job ${env.JOB_NAME}",
            to: 'maxim_arslanov@mail.ru'
        }
    }
}
 
 