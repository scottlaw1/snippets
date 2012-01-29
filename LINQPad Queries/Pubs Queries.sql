select distinct type
from titles

select *
from titles
where type = 'popular_comp'
order by pubdate desc