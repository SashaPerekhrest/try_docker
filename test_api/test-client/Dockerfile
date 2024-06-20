FROM node:15.13-alpine
WORKDIR /app
COPY . .
RUN npm install -g npm
COPY . /app
RUN npm run build
CMD ["npm", "start"]
