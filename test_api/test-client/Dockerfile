FROM node:15.13-alpine
WORKDIR /app
COPY . .
RUN apk add --update nodejs nodejs-npm
RUN npm install -g npm
RUN npm ci
COPY . /app
RUN npm run build
CMD ["npm", "start"]
