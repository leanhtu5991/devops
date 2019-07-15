FROM php:7.2.2-apache
RUN apt-get update && apt-get install XXX
EXPOSE 3000
COPY your-favorite-tool-here