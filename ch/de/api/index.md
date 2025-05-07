---
title: API
ref: api
type: API Documentation
menubar: none
---

Der <a href="/ch/de/knowledge-base/madaster-glossary#application-programming-interface-api" target="_blank">Madaster API</a>-Endpunkt kann verwendet werden, um mit der Madaster-Plattform und ihren Funktionen zu interagieren. Diese API deckt noch nicht alle Funktionen der Plattform vollständig ab, bitte beachten Sie die [OpenAPI-Dokumentation](https://api.madaster.com/).

## News zu Entwicklungen
Melden Sie sich für den Newsletter (auf Englisch) an, um Updates bezüglich der API zu erhalten.
<!-- Begin Mailchimp Signup Form -->
<link href="//cdn-images.mailchimp.com/embedcode/classic-071822.css" rel="stylesheet" type="text/css">
<style type="text/css">
	#mc_embed_signup{background:#fff; clear:left; font:14px Helvetica,Arial,sans-serif;  width:600px;}
	/* Add your own Mailchimp form style overrides in your site stylesheet or in this style block.
	   We recommend moving this block and the preceding CSS link to the HEAD of your HTML file. */
</style>
<div id="mc_embed_signup">
    <form action="https://tech.us11.list-manage.com/subscribe/post?u=781d4269174ddb8c0dcf121fd&amp;id=d2e51fe3ef&amp;f_id=00028de0f0" method="post" id="mc-embedded-subscribe-form" name="mc-embedded-subscribe-form" class="validate" target="_blank" novalidate>
        <div id="mc_embed_signup_scroll">
        <h2>Abonnieren Sie die Madaster API Updates</h2>
        <div class="indicates-required"><span class="asterisk">*</span> erforderliche Angaben</div>
<div class="mc-field-group">
	<label for="mce-EMAIL">E-Mail-Adresse  <span class="asterisk">*</span>
</label>
	<input type="email" value="" name="EMAIL" class="required email" id="mce-EMAIL" required>
	<span id="mce-EMAIL-HELPERTEXT" class="helper_text"></span>
</div>
<div class="mc-field-group">
	<label for="mce-FNAME">Vorname </label>
	<input type="text" value="" name="FNAME" class="" id="mce-FNAME">
	<span id="mce-FNAME-HELPERTEXT" class="helper_text"></span>
</div>
<div class="mc-field-group">
	<label for="mce-LNAME">Nachname </label>
	<input type="text" value="" name="LNAME" class="" id="mce-LNAME">
	<span id="mce-LNAME-HELPERTEXT" class="helper_text"></span>
</div>
	<div id="mce-responses" class="clear foot">
		<div class="response" id="mce-error-response" style="display:none"></div>
		<div class="response" id="mce-success-response" style="display:none"></div>
	</div>    <!-- real people should not fill this in and expect good things - do not remove this or risk form bot signups-->
    <div style="position: absolute; left: -5000px;" aria-hidden="true"><input type="text" name="b_781d4269174ddb8c0dcf121fd_d2e51fe3ef" tabindex="-1" value=""></div>
        <div class="optionalParent">
            <div class="clear foot">
                <input type="submit" value="Jetzt abonnieren" name="subscribe" id="mc-embedded-subscribe" class="button">
                <p class="brandingLogo"><a href="http://eepurl.com/h9i465" title="Mailchimp - email marketing made easy and fun"><img src="https://eep.io/mc-cdn-images/template_images/branding_logo_text_dark_dtp.svg"></a></p>
            </div>
        </div>
    </div>
</form>
</div>
<script type='text/javascript' src='//s3.amazonaws.com/downloads.mailchimp.com/js/mc-validate.js'></script><script type='text/javascript'>(function($) {window.fnames = new Array(); window.ftypes = new Array();fnames[0]='EMAIL';ftypes[0]='email';fnames[1]='FNAME';ftypes[1]='text';fnames[2]='LNAME';ftypes[2]='text';fnames[3]='ADDRESS';ftypes[3]='address';fnames[4]='PHONE';ftypes[4]='phone';fnames[5]='BIRTHDAY';ftypes[5]='birthday';}(jQuery));var $mcj = jQuery.noConflict(true);</script>
<!--End mc_embed_signup-->

## Token
Um auf die API-Ressourcen zugreifen zu können, benötigen Sie einen Autorisierungs-Token. Wenn Sie noch keinen haben, lesen Sie das folgende Kapitel über die Autorisierung. Dieser Token sollte als Header mit dem Namen 'X-API-Key' gesendet werden, wodurch die Anfrage mit dem Token authentifiziert wird.

## Autorisierung
Um auf die Dienste der API zugreifen zu können, benötigen Sie einen API-Schlüssel. Dieser Schlüssel muss im *X-API-Key*-Header an die Anfrage angehängt werden. Um einen API-Schlüssel zu erhalten, müssen Sie einen Token in der Madaster-Plattform hinzufügen oder den Administrator Ihres Accounts bitten, dies für Sie zu tun. Dadurch erhalten Sie Zugriff auf die Ressourcen und die damit verbundenen Entitäten.

### Hinzufügen eines Tokens zu einem Account, Ordner, Objekt oder einer Datenbank

1. Klicken Sie auf der gewünschten Ebene auf den Tab **Benutzer**, zugänglich über das Symbol <iconify-icon inline icon='mdi-dots-vertical'/> am Ende der Tableiste.
1. Klicken Sie auf **API-Token hinzufügen** <iconify-icon inline icon='mdi-account-plus-outline'/>.
1. Geben Sie einen Namen für den Token ein und kopieren Sie den generierten Token. Wählen Sie die Berechtigungsstufe sowie die Ablaufzeit und klicken Sie abschließend auf **Speichern**

## Versionen
Die API wird ständig verbessert, so dass im Laufe der Zeit weitere Versionen der Schnittstelle hinzugefügt werden. Welche Versionen welche API-Aufrufe unterstützen, finden Sie in der [OpenAPI-Dokumentation](https://api.madaster.com/). Es wird empfohlen, immer die neueste verfügbare Version für eine API-Anfrage zu verwenden. Die alten Versionen bleiben jedoch noch eine Zeit lang aus Legacy-Zwecken verfügbar. Um eine API-Version auszuwählen, hängen Sie das Versions-Tag an den API-Endpunkt an. Für Version 4.0 verwenden Sie zum Beispiel https://api.madaster.com/api/v4.0

## Beispiele
Im [Github-Repository](https://github.com/Madaster/examples) finden Sie einige Beispiele, wie Sie mit der API in verschiedenen Programmiersprachen interagieren können.