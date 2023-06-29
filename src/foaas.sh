#!/bin/bash

api="https://www.foaas.com"
user_agent="Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36"

function get_version() {
	curl --request GET \
		--url "$api/version" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}

function get_operations() {
	curl --request GET \
		--url "$api/operations" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}

function get_operation_result() {
	# 1 - operation_name: (string): <operation_name>
	# 2 - from: (string): <from>
	curl --request GET \
		--url "$api/$1/$2" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}
