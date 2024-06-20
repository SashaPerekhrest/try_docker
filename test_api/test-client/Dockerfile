FROM node:15.13-alpine
WORKDIR /app
COPY . .
RUN apk add --update nodejs nodejs-npm
RUN npm install
RUN npm run build
CMD ["npm", "start"]
