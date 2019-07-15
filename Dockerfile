FROM php:7.2.2-apache
FROM jenkins/ssh-slave
RUN apt-get update && apt-get install XXX
COPY your-favorite-tool-here