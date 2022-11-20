Select CommentID,LocationName,CommentContent,MemberName,MemberSurname 
from Comments
inner join Locations
on Comments.LocationID = Locations.LocationID
inner join Members
on Comments.MemberID = Members.MemberID