USE GalloTubeDb;

INSERT INTO Tag(Id, Name) VALUES

(1, '#FelipeNeto'), (2,'#VocêSabia?'),(3,'#WhinderssonNunes'),(4,'#RenatoGarcia'),(5,'#CoisasdeNerd'),(6, '#T3ddy');


INSERT INTO Video VALUES
( 6, 'Tenho 28 anos e só descobri hoje pra que serve isso', 'T3ddy oferece gameplays de jogos como Scribblenauts e Until Dawn, além de eventuais vídeos de tags e vlogs de desafios.', "2023-04-09, 10:05", 11, 'https://i.ytimg.com/vi/xZh_Irpcl6Q/maxresdefault.jpg', 'https://www.youtube.com/embed/Cd9g679y6ssi=WVg7WHmp9dMFsXC');

INSERT INTO Video VALUES
( 4, 'UMA TARDE DIVERTIDA NA NEVE COM MEUS AMIGOS', 'esse canal é basicamente alguns DayVlog do dia-a-dia dele. Ele tem a fama de ser Trou Pós ele vivê Trolando seus amigos mais sempre seus amigos Trolam ele de Volta.', "2023-09-03,26:53",27, 'https://th.bing.com/th/id/OIP.1uG7PFj1CgfRkgvaaGvIvAHaEK?pid=ImgDet&rs=1', 'https://www.youtube.com/embed/UL_o7IyvkcE?si=OQ6YTxWYzCaNfd4Z');


INSERT INTO Video VALUES
( 5, 'Os Melhores Acessórios para Celular!', 'Neste vídeo, eu falo sobre os melhores acessórios para celular. Tem capinha, controle, fone de ouvido, powerbank e muito mais.', "2023-08-29,08:19", 09,'https://th.bing.com/th/id/R.e4114a3837b0735840792e36f3da37fe?rik=Lo9%2fBrry40r14g&pid=ImgRaw&r=0', 'https://www.youtube.com/embed/UL_o7IyvkcE?si=OQ6YTxWYzCaNfd4Z');


INSERT INTO Video VALUES
( 1, 'CONVERSAS MAIS ENGRAÇADAS DA INTERNET V.127', 'Vamos explorar os momentos mais engraçados das conversas na internet que só os brasileiros entendem!', "2023-09-02, 17:21", 18, 'https://odia.ig.com.br/_midias/jpg/2021/03/09/felipe-21387460.jpg', 'https://www.youtube.com/embed/WcpEwcR1ESc?si=oO3O4t_h6cHY3z24');

INSERT INTO Video VALUES
( 1, 'OS MELHORES FORAS DA INTERNET', 'As melhores respostas para mensagens enviadas na internet', "2023-04-03,19:13",20, 'https://www.youtube.com/embed/SoBM8EpHR2Q?si=oqTzUQFZHv4SiEby');




INSERT INTO VideoTag VALUES
( 1, 6),

( 2, 4),

( 3, 5),

( 4, 1),

( 5, 1)