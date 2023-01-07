create table news
(
    id         uuid          not null,
    title      varchar(100)  not null,
    content    varchar(1000) not null,
    created_on timestamp     not null,
    primary key (id)
);