﻿PageName=Teilnehmer
ListStartPattern=^\s*==\[anchor\|#Teilnehmer\]Teilnehmer==\s*$
ListEndPattern=^\s*<!-- hier davor eintragen, nachfolgenden Zeilenumbruch bitte nicht entfernen -->\s*$
WaitingListEndPattern=^\s*<!-- hier davor am Ende eintragen, nachfolgenden Zeilenumbruch bitte nicht entfernen -->\s*$
EntryPattern=^#.*$
MaximumAttendees=100
HardLimit=120
EntryTemplate=$user.Data.Name#if($user.Data.Email), <a href="mailto:$user.Data.Email">E-Mail</a>#end#if($user.Data.Blog), <a href="$user.Data.Blog">Blog</a>#end#if($user.Data.Twitter), <a href="http://twitter.com/$user.Data.Twitter/">Twitter</a>#end#if($user.Data.Xing), <a href="http://xing.com/profile/$user.Data.Xing">XING</a>#end#if($user.Data.Picture), <a href="$user.Data.Picture">Bild</a>#end#if($user.Data.Sponsoring > 0), $user.Data.FormattedSponsoring &euro;#end