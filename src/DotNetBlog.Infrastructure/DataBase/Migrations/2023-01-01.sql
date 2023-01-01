
create table users (
                       id uuid not null,
                       name varchar (60) not null,
                       email varchar(40) not null,
                       hashed_password varchar(50) not null,
                       subscribed_on_emails bool not null,
                       primary key (id)
);

insert into users values ('e7b544f7-6215-42cd-94fa-cff1609008d9', 'Maxim', 'maxim.usat7@gmail.com', '12345', true);


create table articles (
                          id uuid not null,
                          id_author uuid not null,
                          title varchar (100) not null,
                          description varchar(255) not null,
                          minutes_to_read int not null,
                          content bytea not null,
                          primary key (id),
                          foreign key (id_author) references users(id)
);

create table topics
(
    id   uuid        not null,
    name varchar(60) not null,
    primary key (id)
);

create table article_topics
(
    id   uuid        not null,
    id_article uuid not null,
    id_topic uuid not null,
    primary key (id),
    foreign key (id_article) references articles(id),
    foreign key (id_topic) references topics(id)
);